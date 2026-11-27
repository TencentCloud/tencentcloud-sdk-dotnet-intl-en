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
        /// <p>Storage type after data dumping. Valid values: InfrequentAccess: Infrequent Access storage. ColdStorage: Cold storage.</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>File type for data dumping. Valid values: BIG_FILE: Very large files. STD_FILE: Standard files. SMALL_FILE: Small files. ALL: All files.</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>Data dumping behavior. Valid values: Archive: Archive. Noarchive: Do not archive.</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>Trigger time for data dumping. It consists of "DEFAULT_ATIME_" and a number, in the unit of days. Leave this parameter empty when Action is Noarchive.</p>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// <p>Maximum size of a file for data dumping. The value must be in the format of "number + unit". Supported units: K (KiB), M (MiB), and G (GiB).</p>
        /// </summary>
        [JsonProperty("FileMaxSize")]
        public string FileMaxSize{ get; set; }

        /// <summary>
        /// <p>Minimum size of a file for data dumping. The value must be in the format of "number + unit". Supported units: K (KiB), M (MiB), and G (GiB).</p>
        /// </summary>
        [JsonProperty("FileMinSize")]
        public string FileMinSize{ get; set; }

        /// <summary>
        /// <p>Policy type</p>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>Threshold range [10-90]</p>
        /// </summary>
        [JsonProperty("ExpireThreshold")]
        public ulong? ExpireThreshold{ get; set; }

        /// <summary>
        /// <p>Threshold range [10-90]</p>
        /// </summary>
        [JsonProperty("TargetThreshold")]
        public ulong? TargetThreshold{ get; set; }

        /// <summary>
        /// <p>Whether to overwrite a file in CFSTurbo if it has the same name as a file in the external storage.</p><p>true: Overwrite.</p><p>false: Do not overwrite (and hot storage data will not be released).</p><p>If this parameter is left empty, the default value is false.</p>
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }

        /// <summary>
        /// <p>Whether to sync new files to S3 in near real time. true: Near real-time sync (within 30 seconds). false: Sync based on the time configured in the policy. The default value is false. This parameter takes effect only when StorageType=ExternalStorage.</p>
        /// </summary>
        [JsonProperty("IsCreateRealTimeSync")]
        public bool? IsCreateRealTimeSync{ get; set; }

        /// <summary>
        /// <p>Whether to sync modified files to S3 in near real time. true: Near real-time sync (within 30 seconds) / false: Sync based on the time configured in the policy. The default value is false. This parameter takes effect only when StorageType=ExternalStorage. It is independent of IsOverwrite.</p>
        /// </summary>
        [JsonProperty("IsModifyRealTimeSync")]
        public bool? IsModifyRealTimeSync{ get; set; }

        /// <summary>
        /// <p>Whether to sync file deletion to S3. true: Sync deletion (within 30 seconds) / false: Do not sync deletion. The default value is false. If this parameter is set to true, versioning must be enabled for the destination COS Bucket. This parameter takes effect only when StorageType=ExternalStorage.</p>
        /// </summary>
        [JsonProperty("IsSyncDelete")]
        public bool? IsSyncDelete{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsCreateRealTimeSync", this.IsCreateRealTimeSync);
            this.SetParamSimple(map, prefix + "IsModifyRealTimeSync", this.IsModifyRealTimeSync);
            this.SetParamSimple(map, prefix + "IsSyncDelete", this.IsSyncDelete);
        }
    }
}

