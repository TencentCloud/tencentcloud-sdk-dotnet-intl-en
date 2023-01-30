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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetImageRegistryScanStatusOneKeyResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of images
        /// </summary>
        [JsonProperty("ImageTotal")]
        public ulong? ImageTotal{ get; set; }

        /// <summary>
        /// Number of scanned images
        /// </summary>
        [JsonProperty("ImageScanCnt")]
        public ulong? ImageScanCnt{ get; set; }

        /// <summary>
        /// Scanning progress list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageStatus")]
        public ImageProgress[] ImageStatus{ get; set; }

        /// <summary>
        /// Number of successfully scanned images
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// Number of risks
        /// </summary>
        [JsonProperty("RiskCount")]
        public ulong? RiskCount{ get; set; }

        /// <summary>
        /// Scanning progress
        /// </summary>
        [JsonProperty("Schedule")]
        public ulong? Schedule{ get; set; }

        /// <summary>
        /// Scanning status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Remaining scan time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanRemainTime")]
        public ulong? ScanRemainTime{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageTotal", this.ImageTotal);
            this.SetParamSimple(map, prefix + "ImageScanCnt", this.ImageScanCnt);
            this.SetParamArrayObj(map, prefix + "ImageStatus.", this.ImageStatus);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ScanRemainTime", this.ScanRemainTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

