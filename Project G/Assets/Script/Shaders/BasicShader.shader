Shader "LimePapa/BasicShader"
{
	Properties
	{
		_Color("Color", Color) = (1, 1, 1, 1)
	}
	SubShader
	{
		Pass
		{
			Material
			{
				Diffuse[_Color]
			}
			
			Lighting On
		}
	}

	FallBack "Diffuse"
}
