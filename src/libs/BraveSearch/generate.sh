#!/usr/bin/env bash
set -euo pipefail

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
