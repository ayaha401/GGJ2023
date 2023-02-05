Shader "Unlit/DayAndNight"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _DayColor("DayColor", Color) = (1,1,1,1)
        _NightColor("NightColor", Color) = (1,1,1,1) 
        _CurrentTime("Time", Range(0,1)) = 0
        _Alpha("Alpha", Range(0,1)) = 0.5
    }
    SubShader
    {
        Tags 
        { 
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        // Blend SrcAlpha OneMinusSrcAlpha
        Blend Zero SrcColor
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            uniform float3 _DayColor;
            uniform float3 _NightColor;
            uniform float _CurrentTime;
            uniform float _Alpha;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = fixed4(0,0,0,_Alpha);
                col.rgb = lerp(_NightColor, _DayColor, saturate(i.uv.x + _CurrentTime * 2. - 1.));
                // col.rgb *= col.a;
                return col;
            }
            ENDCG
        }
    }
}
