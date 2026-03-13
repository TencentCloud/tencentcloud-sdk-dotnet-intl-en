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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleRule : AbstractModel
    {
        
        /// <summary>
        /// Storage type after data dump. among them: InfrequentAccess: infrequent medium storage; ColdStorage: cold storage.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Data dump FILE type. among them, BIG_FILE: extra large FILE; STD_FILE: regular FILE; SMALL_FILE: SMALL FILE; ALL: ALL files.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Data dumping action. among them, Archive: settlement; Noarchive: no settlement.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Data dump trigger time. consists of "DEFAULT_ATIME_" and a number, in days. keep it empty when Action is Noarchive.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Maximum specification for data dump files. the value needs to use the "number+measurement unit" format, and the supported units are K (KiB), M (MiB), and G (GiB).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileMaxSize")]
        public string FileMaxSize{ get; set; }

        /// <summary>
        /// Minimum specification of the dump file. its numeric value needs to use the "number+measurement unit" format, and the supported units are K (KiB), M (MiB), and G (GiB).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileMinSize")]
        public string FileMinSize{ get; set; }

        /// <summary>
        /// Policy type.
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// Threshold range: 10-90.
        /// </summary>
        [JsonProperty("ExpireThreshold")]
        public ulong? ExpireThreshold{ get; set; }

        /// <summary>
        /// Threshold range: 10-90.
        /// </summary>
        [JsonProperty("TargetThreshold")]
        public ulong? TargetThreshold{ get; set; }

        /// <summary>
        /// When a file in CFSTurbo and an external storage have the same name, whether to overwrite.
        /// 
        /// Override.
        /// 
        /// false: not overwrite (at the same time will not release hot data storage).
        /// 
        /// Default false when empty.
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "FileMaxSize", this.FileMaxSize);
            this.SetParamSimple(map, prefix + "FileMinSize", this.FileMinSize);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "ExpireThreshold", this.ExpireThreshold);
            this.SetParamSimple(map, prefix + "TargetThreshold", this.TargetThreshold);
            this.SetParamSimple(map, prefix + "IsOverwrite", this.IsOverwrite);
        }
    }
}

