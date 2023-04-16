#version 330 core

in vec3 FragPos;

//uniform sampler2D t0;
//uniform sampler2D t1;

layout (location = 0) out vec4 FragColor;
layout (location = 1) out vec4 BrightColor;

//
//float rand(vec2 co){
//    return fract(sin(dot(co, vec2(12.9898, 78.233))) * 43758.5453);
//}

void main() {
    vec3 color = vec3(100.0f, 100.0f, 100.0f);
    FragColor = vec4(color, 1.0f);
    float brightness = dot(color, vec3(0.2126, 0.7152, 0.0722));
    if (brightness > 1.0) {
        BrightColor = vec4(color, 1.0f);
    } else {
        BrightColor = vec4(0.0, 0.0, 0.0, 1.0f);
    }
}