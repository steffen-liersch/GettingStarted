FROM alpine

ENV DOCKER_IMAGE_INFO="Alpine Linux"
ENV ENV="/root/.bashrc"

RUN apk --update add bash mc nano
RUN rm -rf /var/cache/apk/*

COPY bin /bin
COPY root /root

RUN chmod 555 /bin/info
