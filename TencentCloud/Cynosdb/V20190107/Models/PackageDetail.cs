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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackageDetail : AbstractModel
    {
        
        /// <summary>
        /// Account ID of `AppId` Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// The unique ID of a resource pack Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// Instance ID Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The successfully deducted capacity Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SuccessDeductSpec")]
        public float? SuccessDeductSpec{ get; set; }

        /// <summary>
        /// Used capacity of a resource pack as of now Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageTotalUsedSpec")]
        public float? PackageTotalUsedSpec{ get; set; }

        /// <summary>
        /// Deduction start time Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Deduction end time Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Extended information Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtendInfo")]
        public string ExtendInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SuccessDeductSpec", this.SuccessDeductSpec);
            this.SetParamSimple(map, prefix + "PackageTotalUsedSpec", this.PackageTotalUsedSpec);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExtendInfo", this.ExtendInfo);
        }
    }
}

