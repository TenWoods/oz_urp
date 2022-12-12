using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Test_Asset : RenderPipelineAsset
{
    protected override RenderPipeline CreatePipeline()
    {
        return new Test_Pipeline();
    }
}
