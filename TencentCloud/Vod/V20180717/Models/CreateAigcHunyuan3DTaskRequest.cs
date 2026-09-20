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

    public class CreateAigcHunyuan3DTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>On-demand <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled with the app ID to access resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Reference image information for generating a 3D model.</p><p>Input parameter limitation: The maximum array length is 1.</p><p>The three input parameters ImageInfos, MultiViewImageInfos, and Prompt are mutually exclusive. One and only one must be filled in.</p>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcHunyuan3DReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>Multi-perspective image information used to generate a 3D model.</p><p>Input limits: The array length must be between 2 and 8, and the front perspective must be included.</p><p>The three input parameters ImageInfos, MultiViewImageInfos, and Prompt are mutually exclusive with each other. One and only one must be filled in.</p>
        /// </summary>
        [JsonProperty("MultiViewImageInfos")]
        public AigcHunyuan3DMultiViewImageInfo[] MultiViewImageInfos{ get; set; }

        /// <summary>
        /// <p>Prompt for generating a 3D model.</p><p>Input parameter limit: up to 1024 utf-8 characters.</p><p>ImageInfos, MultiViewImageInfos, and Prompt are mutually exclusive. One and only one must be filled in.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Generation Type.</p><p>Enumeration values:</p><ul><li>Normal: Generate a complete 3D asset (geometry + texture);</li><li>Geometry: Generate only the geometry (no texture, faster output speed);</li><li>Texture: Generate only the texture (requires filling in MeshInfos)</li></ul><p>Default value: Normal</p>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// <p>Reference 3D model used to generate a 3D model.</p><p>Input parameter limit: when MeshInfos is filled in, GenerateType must be Texture (texture scenario).</p>
        /// </summary>
        [JsonProperty("MeshInfos")]
        public AigcHunyuan3DMeshInfo[] MeshInfos{ get; set; }

        /// <summary>
        /// <p>Whether to enable output PBR materials.</p><p>Enumeration values:</p><ul><li>Enabled: enable;</li><li>Disabled: disable.</li></ul><p>Default value: Disabled</p>
        /// </summary>
        [JsonProperty("EnablePBR")]
        public string EnablePBR{ get; set; }

        /// <summary>
        /// <p>Number of patches. This parameter is valid only when GenerateType is Normal or Geometry.</p><p>Value range: [3000, 1500000]</p><p>Default value: 500000</p>
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// <p>Whether to retain UV unfolding.</p><p>Enumeration values:</p><ul><li>Enabled: retained;</li><li>Disabled: not retain.</li></ul><p>Default value: Disabled</p>
        /// </summary>
        [JsonProperty("KeepUV")]
        public string KeepUV{ get; set; }

        /// <summary>
        /// <p>Result format. An extra output format in addition to the default return of obj and glb.</p><p>Enumeration values:</p><ul><li>FBX: FBX format file.</li></ul>
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// <p>Random Seed. Results are reproducible with the same Seed input.</p><p>Value range: [0, 2147483647]</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>Style control words.</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// <p>Configuration of the output media file of the task.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcHunyuan3DOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context, used to pass through user request information. The value of this field will be returned in the audio and video quality revival completion callback. It can contain up to 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If left blank, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
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
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

