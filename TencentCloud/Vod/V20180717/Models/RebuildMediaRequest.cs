/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class RebuildMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// The file ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <b>The VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID. If you need to access a resource in a subapplication, set this parameter to the subapplication ID; otherwise, leave it empty.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The start offset (seconds). If you do not specify this, the segment will start from the beginning of the video.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// The end offset (seconds). If you do not specify this, the segment will end at the end of the video.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// The video quality remastering parameters.
        /// </summary>
        [JsonProperty("RepairInfo")]
        public RepairInfo RepairInfo{ get; set; }

        /// <summary>
        /// The smart frame interpolation parameters.
        /// </summary>
        [JsonProperty("VideoFrameInterpolationInfo")]
        public VideoFrameInterpolationInfo VideoFrameInterpolationInfo{ get; set; }

        /// <summary>
        /// The super resolution parameters.
        /// </summary>
        [JsonProperty("SuperResolutionInfo")]
        public SuperResolutionInfo SuperResolutionInfo{ get; set; }

        /// <summary>
        /// The high dynamic range (HDR) parameters.
        /// </summary>
        [JsonProperty("HDRInfo")]
        public HDRInfo HDRInfo{ get; set; }

        /// <summary>
        /// The image noise removal parameters.
        /// </summary>
        [JsonProperty("VideoDenoiseInfo")]
        public VideoDenoiseInfo VideoDenoiseInfo{ get; set; }

        /// <summary>
        /// The noise removal parameters.
        /// </summary>
        [JsonProperty("AudioDenoiseInfo")]
        public AudioDenoiseInfo AudioDenoiseInfo{ get; set; }

        /// <summary>
        /// The color enhancement parameters.
        /// </summary>
        [JsonProperty("ColorInfo")]
        public ColorEnhanceInfo ColorInfo{ get; set; }

        /// <summary>
        /// The detail enhancement parameters.
        /// </summary>
        [JsonProperty("SharpInfo")]
        public SharpEnhanceInfo SharpInfo{ get; set; }

        /// <summary>
        /// The face enhancement parameters.
        /// </summary>
        [JsonProperty("FaceInfo")]
        public FaceEnhanceInfo FaceInfo{ get; set; }

        /// <summary>
        /// The low-light enhancement parameters.
        /// </summary>
        [JsonProperty("LowLightInfo")]
        public LowLightEnhanceInfo LowLightInfo{ get; set; }

        /// <summary>
        /// The banding removal parameters.
        /// </summary>
        [JsonProperty("ScratchRepairInfo")]
        public ScratchRepairInfo ScratchRepairInfo{ get; set; }

        /// <summary>
        /// The artifact removal (smoothing) parameters.
        /// </summary>
        [JsonProperty("ArtifactRepairInfo")]
        public ArtifactRepairInfo ArtifactRepairInfo{ get; set; }

        /// <summary>
        /// The output parameters of the file.
        /// </summary>
        [JsonProperty("TargetInfo")]
        public RebuildMediaTargetInfo TargetInfo{ get; set; }

        /// <summary>
        /// The session ID, which is used for de-duplication. If there was a request with the same session ID in the last three days, an error will be returned for the current request. The session ID can contain up to 50 characters. If you do not pass this parameter or pass in an empty string, duplicate sessions will not be identified.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The source context, which is used to pass through user request information. The `ProcedureStateChanged` callback will return the value of this parameter. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// The task priority, which can be a value from -10 to 10. The higher the value, the higher the priority. If this parameter is left empty, 0 will be used.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamObj(map, prefix + "RepairInfo.", this.RepairInfo);
            this.SetParamObj(map, prefix + "VideoFrameInterpolationInfo.", this.VideoFrameInterpolationInfo);
            this.SetParamObj(map, prefix + "SuperResolutionInfo.", this.SuperResolutionInfo);
            this.SetParamObj(map, prefix + "HDRInfo.", this.HDRInfo);
            this.SetParamObj(map, prefix + "VideoDenoiseInfo.", this.VideoDenoiseInfo);
            this.SetParamObj(map, prefix + "AudioDenoiseInfo.", this.AudioDenoiseInfo);
            this.SetParamObj(map, prefix + "ColorInfo.", this.ColorInfo);
            this.SetParamObj(map, prefix + "SharpInfo.", this.SharpInfo);
            this.SetParamObj(map, prefix + "FaceInfo.", this.FaceInfo);
            this.SetParamObj(map, prefix + "LowLightInfo.", this.LowLightInfo);
            this.SetParamObj(map, prefix + "ScratchRepairInfo.", this.ScratchRepairInfo);
            this.SetParamObj(map, prefix + "ArtifactRepairInfo.", this.ArtifactRepairInfo);
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

