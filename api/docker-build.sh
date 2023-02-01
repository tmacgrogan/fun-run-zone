tag='latest'
build_only=0

while getopts tag:t:build_only:b flag
do
  case "${flag}" in
    tag|t)
      tag=${OPTARG};;
    build_only|b)
      build_only=1;;
  esac
done

docker build -t fun-run-zone/api:$tag .

if [ $build_only != 1 ]
  then
    container_name="fun_run_zone__latest_build"
    if [ ! -z $(docker ps -a | grep $container_name) ]
      then
        docker rm -f $container_name
    fi
    docker run -d --name $container_name fun-run-zone/api:$tag
fi

#debug wait
#read -n 1 -s