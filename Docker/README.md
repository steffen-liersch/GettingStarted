# Getting Started with Docker

- [Install Docker Desktop on Windows](https://docs.docker.com/docker-for-windows/install/)
- [Install Docker Engine on Debian](https://docs.docker.com/engine/install/debian/)
- [Install Docker Engine on Ubuntu](https://docs.docker.com/engine/install/ubuntu/)
- [Docker Hub - library and community for container images](https://hub.docker.com/)

## Documentation

- [Dockerfile Documentation](https://docs.docker.com/engine/reference/builder/)
- [Docker Compose Documentation](https://docs.docker.com/compose/)

## Command Line Examples

```sh
# List all containers
docker ps

# List all images
docker image ls

# List all volumes
docker volume ls
```

## Using a Remote Docker Engine

```sh
# Specify the host name and port of a remote instance to be used
DOCKER_HOST=tcp://example:2375
```
