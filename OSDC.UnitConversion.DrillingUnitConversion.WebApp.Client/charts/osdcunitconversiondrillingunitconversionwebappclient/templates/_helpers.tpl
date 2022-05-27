{{/*
Expand the name of the chart.
*/}}
{{- define "osdcunitconversiondrillingunitconversionwebappclient.name" -}}
{{- default .Chart.Name .Values.nameOverride | trunc 63 | trimSuffix "-" }}
{{- end }}

{{/*
Create a default fully qualified app name.
We truncate at 63 chars because some Kubernetes name fields are limited to this (by the DNS naming spec).
If release name contains chart name it will be used as a full name.
*/}}
{{- define "osdcunitconversiondrillingunitconversionwebappclient.fullname" -}}
{{- if .Values.fullnameOverride }}
{{- .Values.fullnameOverride | trunc 63 | trimSuffix "-" }}
{{- else }}
{{- $name := default .Chart.Name .Values.nameOverride }}
{{- if contains $name .Release.Name }}
{{- .Release.Name | trunc 63 | trimSuffix "-" }}
{{- else }}
{{- printf "%s-%s" .Release.Name $name | trunc 63 | trimSuffix "-" }}
{{- end }}
{{- end }}
{{- end }}

{{/*
Create chart name and version as used by the chart label.
*/}}
{{- define "osdcunitconversiondrillingunitconversionwebappclient.chart" -}}
{{- printf "%s-%s" .Chart.Name .Chart.Version | replace "+" "_" | trunc 63 | trimSuffix "-" }}
{{- end }}

{{/*
Common labels
*/}}
{{- define "osdcunitconversiondrillingunitconversionwebappclient.labels" -}}
helm.sh/chart: {{ include "osdcunitconversiondrillingunitconversionwebappclient.chart" . }}
{{ include "osdcunitconversiondrillingunitconversionwebappclient.selectorLabels" . }}
{{- if .Chart.AppVersion }}
app.kubernetes.io/version: {{ .Chart.AppVersion | quote }}
{{- end }}
app.kubernetes.io/managed-by: {{ .Release.Service }}
{{- end }}

{{/*
Selector labels
*/}}
{{- define "osdcunitconversiondrillingunitconversionwebappclient.selectorLabels" -}}
app.kubernetes.io/name: {{ include "osdcunitconversiondrillingunitconversionwebappclient.name" . }}
app.kubernetes.io/instance: {{ .Release.Name }}
{{- end }}

{{/*
Create the name of the service account to use
*/}}
{{- define "osdcunitconversiondrillingunitconversionwebappclient.serviceAccountName" -}}
{{- if .Values.serviceAccount.create }}
{{- default (include "osdcunitconversiondrillingunitconversionwebappclient.fullname" .) .Values.serviceAccount.name }}
{{- else }}
{{- default "default" .Values.serviceAccount.name }}
{{- end }}
{{- end }}
