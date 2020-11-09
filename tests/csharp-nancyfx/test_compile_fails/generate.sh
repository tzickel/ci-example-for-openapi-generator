#!/usr/bin/env bash
set -x
SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null 2>&1 && pwd )"

OPENAPI_IMAGE_NAME=openapitools/openapi-generator-cli

# This should be changed to call the java version itself (simply don't have java on my comp)
docker run --rm --user `id -u`:`id -g` -v "${SCRIPT_DIR}":/local "${OPENAPI_IMAGE_NAME}" generate -i /local/bug.yaml -g csharp-nancyfx -o /local/autogen
