from fastapi import FastAPI

app = FastAPI()

@app.get("/talk")
def hello():
    return "hello from theta"

@app.get("/")
def root():
    return "root-url"