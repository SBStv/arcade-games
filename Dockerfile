FROM pierrezemb/gostatic
COPY index.html frogger.html /srv/http/
CMD ["-port","8080","-https-promote", "-enable-logging"]
