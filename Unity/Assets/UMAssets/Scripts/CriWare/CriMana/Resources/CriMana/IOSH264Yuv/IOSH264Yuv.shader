﻿// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "CriMana/IOSH264Yuv" {
	Properties {
		_MainTex  ("Texture", 2D)   = "white" {}
	}

	SubShader {
		Tags {"Queue" = "Transparent"}

		Pass {
			Blend Off
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#include "UnityCG.cginc"

			sampler2D TextureY;
			sampler2D TextureUV;
			float4x4  MovieUvTransform;

			struct appdata {
				float4 vertex   : POSITION;
				half2  texcoord : TEXCOORD0;
			};

			struct v2f {
				float4   pos : SV_POSITION;
				half2     uv : TEXCOORD0;
			};

			float4 _MainTex_ST;

			v2f vert(appdata v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv  = mul(MovieUvTransform, float4(TRANSFORM_TEX(v.texcoord, _MainTex), 0.0, 1.0));
				return o;
			}

			static const fixed3x3 yuv_to_rgb = {
				{1.16438,      0.0,  1.59603},
				{1.16438, -0.39176, -0.81297},
				{1.16438,  2.01723,      0.0}
				};

			fixed4 frag(v2f i) : COLOR
			{
				fixed3 yuv = {
					(tex2D(TextureY, i.uv).r - 0.06275),
					(tex2D(TextureUV, i.uv).rg - 0.50196)
					};
				fixed4 color;
				color.rgb = mul(yuv_to_rgb, yuv);
				color.a   = 1.0;
				return color;
			}
//			#endif
			ENDCG
		}
	}
}
