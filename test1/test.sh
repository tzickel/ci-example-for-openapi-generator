java -jar ${GENERATOR_PATH} generate -i bug.yaml -g cpp-restsdk -o autogen
cmake .
make -j8
FLASK_APP=server.py flask run --port 8080 &
sleep 2
./client
