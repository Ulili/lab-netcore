#!/bin/bash
# "Bruno Luis Cardoso Novo <bruno.novo@concrete.com.br>"
# Script to manage the containers execution

## Variables for images build.
$JOIN_RABBIT2_RABBIT1="rabbitmqctl stop_app; rabbitmqctl join_cluster rabbit@rabbitmq1; rabbitmqctl start_app"
$JOIN_RABBIT3_RABBIT1="rabbitmqctl stop_app; rabbitmqctl join_cluster rabbit@rabbitmq1; rabbitmqctl start_app"
$JOIN_RABBIT4_RABBIT1="rabbitmqctl stop_app; rabbitmqctl join_cluster rabbit@rabbitmq1; rabbitmqctl start_app"
#$OPTIONAL_COMMAND="rabbitmqctl set_policy ha-all '' '{"ha-mode":"all", "ha-sync-mode":"automatic"}' "


#Subindo os container's do rabbitmq
Write-Output -n "Starting container..."
docker-compose down
docker-compose up 
Start-Sleep 15
docker exec -ti rabbitmq2 bash -c "$JOIN_RABBIT2_RABBIT1"
docker exec -ti rabbitmq3 bash -c "$JOIN_RABBIT3_RABBIT1"
docker exec -ti rabbitmq4 bash -c "$JOIN_RABBIT4_RABBIT1"
docker exec -ti rabbitmq1 bash -c "$OPTIONAL_COMMAND"