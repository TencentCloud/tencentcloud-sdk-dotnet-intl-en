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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EDRScanRecordItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Task primary key ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>Task name, for example, Malware_20260702_030000</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Scan type</p><p>Enumeration values:</p><ul><li>MANNAL: Manual scan</li><li>CYCLE: Scheduled scan</li></ul>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Scheduled scheduling description (has a value when ScanType=1), for example, "Every day at 03:00:00"</p>
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

        /// <summary>
        /// <p>Task asset type: 0=host scan, 1=container scan</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>AppId list of accounts involved in scanning target</p>
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>Task creator account name</p>
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>Cloud type: 0=Tencent Cloud, 1=AWS, 2=Azure, 4=Alibaba Cloud</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>Asset selection method: all=all assets, tag=select by tag, direct=direct selection</p>
        /// </summary>
        [JsonProperty("AssetSelectionType")]
        public string AssetSelectionType{ get; set; }

        /// <summary>
        /// <p>Total number of assets scanned</p>
        /// </summary>
        [JsonProperty("TotalAssetCount")]
        public long? TotalAssetCount{ get; set; }

        /// <summary>
        /// <p>Creator account AppId (the frontend judges operation permission based on this)</p>
        /// </summary>
        [JsonProperty("CreateAppID")]
        public ulong? CreateAppID{ get; set; }

        /// <summary>
        /// <p>Creator account uin</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>Creator account name</p>
        /// </summary>
        [JsonProperty("CreatorName")]
        public string CreatorName{ get; set; }

        /// <summary>
        /// <p>Creator cloud type: 0=Tencent Cloud, 1=AWS, 2=Azure, 4=Alibaba Cloud</p>
        /// </summary>
        [JsonProperty("CreatorCloudType")]
        public long? CreatorCloudType{ get; set; }

        /// <summary>
        /// <p>Task start time. Format: 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Task end time. If not ended, it is an empty string</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>WAIT: pending scan, SCANNING: scan in progress, FINISHED: completed, FAILED: failure, CANCELED: stopped</p><p>Enumeration values:</p><ul><li>WAIT: pending scan</li><li>SCANNING: scan in progress</li><li>FINISHED: completed</li><li>FAILED: failure</li><li>CANCELED: stopped</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "ScheduleDesc", this.ScheduleDesc);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "AssetSelectionType", this.AssetSelectionType);
            this.SetParamSimple(map, prefix + "TotalAssetCount", this.TotalAssetCount);
            this.SetParamSimple(map, prefix + "CreateAppID", this.CreateAppID);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatorName", this.CreatorName);
            this.SetParamSimple(map, prefix + "CreatorCloudType", this.CreatorCloudType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

