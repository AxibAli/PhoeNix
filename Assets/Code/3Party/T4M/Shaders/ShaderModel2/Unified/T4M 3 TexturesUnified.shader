Shader "RO/T4M/3 Textures" {
Properties {
	_Splat0 ("Layer 1", 2D) = "white" {}
	_Splat1 ("Layer 2", 2D) = "white" {}
	_Splat2 ("Layer 3", 2D) = "white" {}
	_Control ("Control (RGBA)", 2D) = "white" {}
	_MainTex ("Never Used", 2D) = "white" {}
	
	_Color("Color", Color) = (1,1,1,1) 
	_AlbedoScale ("Albedo Scale", Range(0.0, 1.0)) = 1.0 
}
                
SubShader {
	Tags {
   "SplatCount" = "3"
   "RenderType" = "Opaque"
	}
CGPROGRAM
#pragma multi_compile __ _Ambient_ON
#pragma surface surf T4M exclude_path:prepass noforwardadd
#pragma exclude_renderers xbox360 ps3
inline fixed4 LightingT4M (SurfaceOutput s, fixed3 lightDir, fixed atten)
{
	fixed diff = dot (s.Normal, lightDir);
	fixed4 c;
	c.rgb = s.Albedo * _LightColor0.rgb * (diff * atten * 2);
	c.a = 0.0;
	return c;
}
struct Input {
	float2 uv_Control : TEXCOORD0;
	float2 uv_Splat0 : TEXCOORD1;
	float2 uv_Splat1 : TEXCOORD2;
	float2 uv_Splat2 : TEXCOORD3;
};
 
sampler2D _Control;
sampler2D _Splat0,_Splat1,_Splat2;
float4 _Color;
fixed _AlbedoScale;

float4 _LightColor;
float _LightScale;
 
void surf (Input IN, inout SurfaceOutput o) {
	fixed3 splat_control = tex2D (_Control, IN.uv_Control).rgba;
		
	fixed3 lay1 = tex2D (_Splat0, IN.uv_Splat0);
	fixed3 lay2 = tex2D (_Splat1, IN.uv_Splat1);
	fixed3 lay3 = tex2D (_Splat2, IN.uv_Splat2);
	o.Alpha = 0.0;
	o.Albedo.rgb = (lay1 * splat_control.r + lay2 * splat_control.g + lay3 * splat_control.b ) * _Color.rgb * _AlbedoScale;
	
	#if defined(_Ambient_ON)
	fixed4 lightColor = UNITY_LIGHTMODEL_AMBIENT;
	o.Albedo.rgb *= lightColor.rgb * lightColor.a;
	#endif
}
ENDCG 
}
FallBack "Diffuse"
}
