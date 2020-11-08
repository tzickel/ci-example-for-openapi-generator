from flask import Flask, Response
app = Flask(__name__)


@app.route('/GetAnObjectWithNumbers')
def GetAnObjectWithNumbers():
    return {"num1": 1, "num2": 1.0}
