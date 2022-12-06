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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanResult : AbstractModel
    {
        
        /// <summary>
        /// Business return code
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// Unique data ID
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// Detection completion timestamp
        /// </summary>
        [JsonProperty("ScanFinishTime")]
        public ulong? ScanFinishTime{ get; set; }

        /// <summary>
        /// Whether non-compliant information is detected
        /// </summary>
        [JsonProperty("HitFlag")]
        public bool? HitFlag{ get; set; }

        /// <summary>
        /// Whether it is a stream
        /// </summary>
        [JsonProperty("Live")]
        public bool? Live{ get; set; }

        /// <summary>
        /// Business return description
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// Detection result, which will be returned if `Code` is 0
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanPiece")]
        public ScanPiece[] ScanPiece{ get; set; }

        /// <summary>
        /// Detection task submission timestamp
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public ulong? ScanStartTime{ get; set; }

        /// <summary>
        /// Voice detection scenario, which corresponds to the `Scene` at the time of request
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// Voice detection task ID, which is assigned by the backend
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// File or stream address
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Detection task execution result status. Valid values:
        /// <li>Start: Task started</li>
        /// <li>Success: Task ended successfully</li>
        /// <li>Error: An exception occurs</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// ID of the application submitted for detection
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "ScanFinishTime", this.ScanFinishTime);
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamSimple(map, prefix + "Live", this.Live);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamArrayObj(map, prefix + "ScanPiece.", this.ScanPiece);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
        }
    }
}

