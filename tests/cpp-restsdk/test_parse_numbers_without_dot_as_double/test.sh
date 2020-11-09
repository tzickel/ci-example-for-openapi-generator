#!/usr/bin/env bash
set -xe

cmake .
make -j8
FLASK_APP=server.py flask run --port 8080 &
sleep 2
./client
