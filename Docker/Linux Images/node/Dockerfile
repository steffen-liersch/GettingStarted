FROM node:12-alpine

ENV DOCKER_IMAGE_INFO="Alpine Linux with Node.js"
ENV ENV="/root/.bashrc"

RUN apk --update add bash mc nano && rm -rf /var/cache/apk/*

COPY bin /bin
COPY root /root

RUN chmod 555 /bin/info

ENTRYPOINT sh
