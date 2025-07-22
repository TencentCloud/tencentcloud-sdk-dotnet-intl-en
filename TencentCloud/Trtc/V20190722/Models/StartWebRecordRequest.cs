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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartWebRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// URL of the web page to be recorded
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// Maximum recording duration limit, in seconds. Valid range: [1800, 36000]. Default is 36,000 seconds (10 hours).
        /// </summary>
        [JsonProperty("MaxDurationLimit")]
        public ulong? MaxDurationLimit{ get; set; }

        /// <summary>
        /// [Required] Parameters related to cloud storage. Currently, Tencent Cloud Object Storage and Tencent Cloud VOD are supported, but third-party cloud storage is not supported. The storage format of the output file only supports hls or mp4.
        /// </summary>
        [JsonProperty("StorageParams")]
        public StorageParams StorageParams{ get; set; }

        /// <summary>
        /// web-page recording video parameters
        /// </summary>
        [JsonProperty("WebRecordVideoParams")]
        public WebRecordVideoParams WebRecordVideoParams{ get; set; }

        /// <summary>
        /// [Required] The SDKAppID of the TRTC room 
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// When sensitive to repetitive tasks, please pay attention to this value: To avoid tasks being initiated repeatedly in a short period, leading to task duplication, pass in the recording RecordId to identify the current task. The RecordId should be less than 32 bytes. If you carry the RecordId and initiate the start recording request more than once, only one task will be started, and the second one will report the error FailedOperation.TaskExist. Note that if the StartWebRecord call fails with an error other than FailedOperation.TaskExist, please change the RecordId and initiate the request again.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// If you want to push the stream to a CDN, you can use the PublishCdnParams.N parameter to set it. It supports pushing streams to up to 10 CDN addresses simultaneously. If the relay address is a Tencent Cloud CDN, please explicitly set IsTencentCdn to 1.
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// The timeout for loading page resources during recording, in seconds. The default value is 0 seconds. This value must be greater than or equal to 0 seconds and less than or equal to 60 seconds. If page load timeout detection is not enabled for the recording page, please do not set this parameter.
        /// </summary>
        [JsonProperty("ReadyTimeout")]
        public ulong? ReadyTimeout{ get; set; }

        /// <summary>
        /// Render mobile mode parameters; do not set this parameter if you are not going to render mobile mode pages.
        /// </summary>
        [JsonProperty("EmulateMobileParams")]
        public EmulateMobileParams EmulateMobileParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "MaxDurationLimit", this.MaxDurationLimit);
            this.SetParamObj(map, prefix + "StorageParams.", this.StorageParams);
            this.SetParamObj(map, prefix + "WebRecordVideoParams.", this.WebRecordVideoParams);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamArrayObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
            this.SetParamSimple(map, prefix + "ReadyTimeout", this.ReadyTimeout);
            this.SetParamObj(map, prefix + "EmulateMobileParams.", this.EmulateMobileParams);
        }
    }
}

