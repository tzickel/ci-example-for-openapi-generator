ARG BASE_IMAGE=mono:6
FROM $BASE_IMAGE

WORKDIR /openapi/
ADD . .

RUN cd test_compile_fails && ./test.sh
