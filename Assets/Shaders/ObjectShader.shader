Shader "Unlit/ObjectShader"
{
    Properties
    {
        _Color("Color", Color) = (0,0,0,0)
        _ColorB("ColorB", Color) = (0,0,0,0)
    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
        Tags { "ForceNoShadowCasting" = "True"}

        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha


            Ztest LEqual
            Zwrite Off

            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv0 : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv0 : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };

            float4 _Color;
            float4 _ColorB;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv0 = v.uv0;
                return o;
            }

            float InverseLerp(float a, float b, float t) {
                return(t - a) / (t - b);
            }

            float4 frag(v2f i) : SV_Target
            {
                // sample the texture

            float value = distance(i.uv0, float2(0.5,0.5));

            float remapped = InverseLerp(0.25, 0.50, value);

            remapped = saturate(remapped);

            remapped = lerp(_Color, _ColorB, remapped);

            float4 color = lerp(_Color, _ColorB, remapped);

            color = saturate(color);

            color = _Color;

            color = lerp(_Color, _ColorB, remapped);

            return color;
            }
            ENDCG
        }
    }
}
