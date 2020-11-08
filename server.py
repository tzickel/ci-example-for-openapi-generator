from flask import Flask, Response
app = Flask(__name__)


@app.route('/GetBackBinaryData')
def GetBackBinaryData():
    return Response(b'Hello, World!', content_type="application/octet-stream")
