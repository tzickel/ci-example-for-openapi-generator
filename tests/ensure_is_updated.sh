#!/usr/bin/env bash
set -xe

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null 2>&1 && pwd )"

for f in "${SCRIPT_DIR}"/*/*/generate.sh
do
    "$f"
done
