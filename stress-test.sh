#!/bin/bash
ip=$(kubectl get ingress -n tc4 -o jsonpath='{.items[?(@.metadata.name=="services-ingress")].status.loadBalancer.ingress[0].ip}')

ab -n 10000 -c 20 "http://$ip/GetContacts/100"
