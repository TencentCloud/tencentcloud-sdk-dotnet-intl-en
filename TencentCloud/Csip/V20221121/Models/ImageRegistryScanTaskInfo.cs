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

    public class ImageRegistryScanTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>Scheduled scan task id.</p>
        /// </summary>
        [JsonProperty("TimedScanConfigId")]
        public ulong? TimedScanConfigId{ get; set; }

        /// <summary>
        /// <p>Automatic matching mode</p><p>Enumeration values:</p><ul><li>BY_CLUSTER: Select by cluster</li><li>LATEST_VERSION: Scan the latest version image only</li><li>LOCAL_IMAGE: Local image</li></ul>
        /// </summary>
        [JsonProperty("AutoMatchMode")]
        public string[] AutoMatchMode{ get; set; }

        /// <summary>
        /// <p>Scan asset mode</p><p>Enumeration values:</p><ul><li>ALL: All</li><li>MANUAL: Manual selection</li><li>AUTO_MATCH: Automatic matching</li></ul>
        /// </summary>
        [JsonProperty("ScopeMode")]
        public string ScopeMode{ get; set; }

        /// <summary>
        /// <p>Task trigger type</p><p>Enumeration values:</p><ul><li>TIMED: scheduled task</li><li>MANUAL: manual triggering</li></ul>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Scan category</p><p>Enumeration values:</p><ul><li>CVE: vulnerability</li><li>RISK: risk</li><li>VIRUS: Trojan</li></ul>
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// <p>Image id scanned</p>
        /// </summary>
        [JsonProperty("ImageIds")]
        public ulong?[] ImageIds{ get; set; }

        /// <summary>
        /// <p>Task status</p><p>Enumeration values:</p><ul><li>RUNNING: Executing</li><li>SUCCESS: Task successful</li><li>TIMEOUT: Task timeout</li><li>FAILED: Task failure</li><li>CANCELLED: Canceled</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Scheduled task associated account name</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>appid of the account associated with the scheduled task</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>uin of the associated account for the scheduled task</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>Scan image count</p>
        /// </summary>
        [JsonProperty("ScanImageCount")]
        public ulong? ScanImageCount{ get; set; }

        /// <summary>
        /// <p>Image count scanned successfully</p>
        /// </summary>
        [JsonProperty("SuccessImageCount")]
        public ulong? SuccessImageCount{ get; set; }

        /// <summary>
        /// <p>Image count of scan failure</p>
        /// </summary>
        [JsonProperty("FailureImageCount")]
        public ulong? FailureImageCount{ get; set; }

        /// <summary>
        /// <p>Number of images ignored by the task</p>
        /// </summary>
        [JsonProperty("IgnoredImageCount")]
        public ulong? IgnoredImageCount{ get; set; }

        /// <summary>
        /// <p>Task cancelled image count</p>
        /// </summary>
        [JsonProperty("CancelledImageCount")]
        public ulong? CancelledImageCount{ get; set; }

        /// <summary>
        /// <p>Scan start time</p><p>Parameter format: hh:mm</p>
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public string ScanStartTime{ get; set; }

        /// <summary>
        /// <p>Scan stop time</p><p>Parameter format: hh:mm</p>
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// <p>Timeout period, in seconds</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>Task cancellation reason</p>
        /// </summary>
        [JsonProperty("CancelReason")]
        public string CancelReason{ get; set; }

        /// <summary>
        /// <p>Task name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Scan task scheduling configuration</p>
        /// </summary>
        [JsonProperty("Schedule")]
        public ImageScanScheduleConfig Schedule{ get; set; }

        /// <summary>
        /// <p>Scan task target</p>
        /// </summary>
        [JsonProperty("Target")]
        public ImageScanAssetTarget Target{ get; set; }

        /// <summary>
        /// <p>Scan task filtering configuration</p>
        /// </summary>
        [JsonProperty("Filter")]
        public ImageScanRegistryFilter Filter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TimedScanConfigId", this.TimedScanConfigId);
            this.SetParamArraySimple(map, prefix + "AutoMatchMode.", this.AutoMatchMode);
            this.SetParamSimple(map, prefix + "ScopeMode", this.ScopeMode);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ScanImageCount", this.ScanImageCount);
            this.SetParamSimple(map, prefix + "SuccessImageCount", this.SuccessImageCount);
            this.SetParamSimple(map, prefix + "FailureImageCount", this.FailureImageCount);
            this.SetParamSimple(map, prefix + "IgnoredImageCount", this.IgnoredImageCount);
            this.SetParamSimple(map, prefix + "CancelledImageCount", this.CancelledImageCount);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "CancelReason", this.CancelReason);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Schedule.", this.Schedule);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
        }
    }
}

