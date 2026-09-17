/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcHunyuan3DTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcHunyuan3DReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MultiViewImageInfos")]
        public AigcHunyuan3DMultiViewImageInfo[] MultiViewImageInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MeshInfos")]
        public AigcHunyuan3DMeshInfo[] MeshInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnablePBR")]
        public string EnablePBR{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KeepUV")]
        public string KeepUV{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcHunyuan3DOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamArrayObj(map, prefix + "MultiViewImageInfos.", this.MultiViewImageInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamArrayObj(map, prefix + "MeshInfos.", this.MeshInfos);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "KeepUV", this.KeepUV);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

