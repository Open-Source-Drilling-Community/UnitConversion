"""Reject release packages whose dependency versions drift from their projects."""
from pathlib import Path
import sys
import xml.etree.ElementTree as ET
import zipfile

project_path = Path(__file__).resolve().parents[1] / "DrillingRazorMudComponents/DrillingRazorMudComponents.csproj"
project = ET.parse(project_path).getroot()
version = project.findtext(".//Version")
expected = {node.attrib["Include"]: node.attrib["Version"] for node in project.iter("PackageReference")}
for node in project.iter("ProjectReference"):
    target = ET.parse(project_path.parent / node.attrib["Include"].replace("\\", "/")).getroot()
    expected[target.findtext(".//PackageId")] = target.findtext(".//Version")

with zipfile.ZipFile(sys.argv[1]) as archive:
    metadata = ET.fromstring(archive.read(next(name for name in archive.namelist() if name.endswith(".nuspec"))))
ns = {"n": "http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd"}
assert metadata.findtext("n:metadata/n:id", namespaces=ns) == "OSDC.UnitConversion.DrillingRazorMudComponents"
assert metadata.findtext("n:metadata/n:version", namespaces=ns) == version
actual = {node.attrib["id"]: node.attrib["version"] for node in metadata.findall(".//n:dependency", ns)}
assert actual == expected, f"Package dependency mismatch: expected {expected}, found {actual}"
print(f"Verified selector {version}: package dependencies match their source project versions.")
