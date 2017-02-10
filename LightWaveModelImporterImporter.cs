using UnityEngine;
using UnityEditor;

/// <summary>
/// LightWave fbx import setting editor
/// These codes are licensed under CC0.
/// http://creativecommons.org/publicdomain/zero/1.0/deed.ja
/// twitter : @izm
/// </summary>
public sealed class LightWaveModelImporter : AssetPostprocessor
{

    //returnの値が小さいほど優先される
    public override int GetPostprocessOrder()
    {
        return 0;
    }

    //==================================================================
    //FBX Import Settings
    //==================================================================

    void OnPreprocessModel()
    {
        var modelImporter = assetImporter as ModelImporter;
        // change material naming for Lightwave Optimazed
        // http://cycling.hateblo.jp/entry/2017/02/10/111135
        modelImporter.materialName = ModelImporterMaterialName.BasedOnModelNameAndMaterialName;
        
        //samples
        /*
        modelImporter.globalScale = 100;
        */
    }

    //==================================================================
    //Texture Settings
    //==================================================================

    //called when imported texture 
    void OnPreprocessTexture()
    {

        //Texture import setting class
        TextureImporter textureImporter = assetImporter as TextureImporter;

        //samples
        /*
        textureImporter.wrapMode = TextureWrapMode.Repeat; 
        textureImporter.filterMode = FilterMode.Point;     
        */
    }
}