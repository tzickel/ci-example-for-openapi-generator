ARG BASE_IMAGE=ubuntu:20.04
FROM $BASE_IMAGE

RUN apt-get update && DEBIAN_FRONTEND="noninteractive" apt-get install -y g++ libcpprest-dev cmake make python3-flask wget

WORKDIR /openapi

# Here we compile the relevent tag
#RUN apt-get update && DEBIAN_FRONTEND="noninteractive" apt-get install -y openjdk-8-jdk-headless git maven
#RUN git clone --depth=1 https://github.com/OpenAPITools/openapi-generator
#RUN cd openapi-generator && mvn install
#ENV GENERATOR_PATH=/openapi/check where the output is jar is !

# Or check aginst a ready version
RUN apt-get update && DEBIAN_FRONTEND="noninteractive" apt-get install -y openjdk-8-jre-headless
RUN wget -q https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/5.0.0-beta2/openapi-generator-cli-5.0.0-beta2.jar -O openapi-generator-cli.jar
ENV GENERATOR_PATH=/openapi/openapi-generator-cli.jar

WORKDIR /openapi/test
ADD . .
RUN cd test2 && ./test.sh
RUN cd test1 && ./test.sh
