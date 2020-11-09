ARG BASE_IMAGE=ubuntu:20.04
FROM $BASE_IMAGE

RUN apt-get update && DEBIAN_FRONTEND="noninteractive" apt-get install -y g++ libcpprest-dev cmake make python3-flask

WORKDIR /openapi/
ADD . .

RUN cd test_parse_numbers_without_dot_as_double && ./test.sh
RUN cd test_binary_string_result && ./test.sh
