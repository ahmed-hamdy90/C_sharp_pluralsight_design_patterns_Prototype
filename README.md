#### This Repository Follow Pluralsight course for [C# Prototype pattern](https://app.pluralsight.com/library/courses/c-sharp-design-patterns-prototype)

##### The Example files:

You can See project files include initial code base and final code which apply prototype pattern Here:

  - The initial base code example at [d972c307ae420e2983b32c8565da52d14071b631 commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Prototype/tree/d972c307ae420e2983b32c8565da52d14071b631)
  - The Final code example at [3e0d7847e1be95b468f243d58044a2f64573d4a1 commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Prototype/tree/3e0d7847e1be95b468f243d58044a2f64573d4a1)
 
There Idea of using Prototype Manager within applying Prototype pattern on example:
 The new Idea under `prototype_manager` branch at [9e4524b2c93bee6e32189520e66da0a5b527720a commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Prototype/tree/9e4524b2c93bee6e32189520e66da0a5b527720a)

**Notice:** Every class has it's own file into same root project structure, as course was decouple some classes into one file.
  
##### Run Example Project:
 
You can Run Example using Docker, if you don't have Docker , you can install Docker Engine from [Here](https://docs.docker.com/engine/install)
 
 - First build docker image

```shell
docker build -t prototypepattern .
```

 - Second run built image

```shell
docker run --name prototypepattern prototypepattern
```