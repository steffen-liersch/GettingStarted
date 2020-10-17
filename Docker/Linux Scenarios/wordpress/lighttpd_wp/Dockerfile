FROM alpine:3.12

EXPOSE 80/tcp

RUN apk --update add bash mc nano lighttpd \
  php7 php7-bcmath php7-bz2 php7-cgi php7-ctype php7-curl php7-dom php7-enchant \
  php7-exif php7-fpm php7-gd php7-gettext php7-gmp php7-iconv php7-imap php7-intl php7-json \
  php7-mbstring php7-opcache php7-openssl php7-phar php7-posix php7-pspell php7-recode \
  php7-session php7-simplexml php7-sockets php7-sysvmsg php7-sysvsem php7-sysvshm \
  php7-tidy php7-xml php7-xmlreader php7-xmlrpc php7-xmlwriter php7-xsl php7-zip \
  php7-mysqli php7-sqlite3 && \
  rm -rf /var/cache/apk/*

#RUN wget -P /root https://wordpress.org/latest.zip
ADD https://wordpress.org/latest.zip /root/latest.zip

RUN unzip /root/latest.zip -d /root
RUN mv /root/wordpress/* /var/www
RUN rmdir /root/wordpress
RUN rm /root/latest.zip

RUN rm -rf /var/www/localhost
RUN mkdir -p /run/lighttpd
RUN adduser -DH -s /bin/false -G www-data www-data
RUN chown www-data /run/lighttpd

COPY . /

ENTRYPOINT \
  php /root/init-db.php & \
  php-fpm7 -D; \
  lighttpd -D -f /etc/lighttpd/lighttpd.conf
