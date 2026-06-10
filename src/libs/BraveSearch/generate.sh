#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Brave Search has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: --security-scheme sends the API key directly as X-Subscription-Token header
#       (no jq/yq conversion or PrepareRequest hook needed).
autosdk generate openapi.yaml \
  --namespace BraveSearch \
  --clientClassName BraveSearchClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-Subscription-Token

rm -rf ../../cli/BraveSearch.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/BraveSearch.CLI \
  --sdk-project ../../libs/BraveSearch/BraveSearch.csproj \
  --targetFramework net10.0 \
  --namespace BraveSearch \
  --clientClassName BraveSearchClient \
  --package-id BraveSearch.CLI \
  --tool-command-name brave-search \
  --user-secrets-id BraveSearch.CLI \
  --api-key-env-var BRAVESEARCH_API_KEY \
  --base-url-env-var BRAVESEARCH_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-Subscription-Token
