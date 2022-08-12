FROM postman/newman:5.3.0-alpine as base
WORKDIR /etc/newman

RUN npm install -g newman-reporter-html
RUN npm install -g newman-reporter-json-summary

COPY ["tests/", "./"]

ENTRYPOINT newman run sample.postman_collection.json  --environment=sample-local.postman_environment.json --reporters cli,json --reporter-json-export /data/results/outputfile.json