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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanTaskInfoList : AbstractModel
    {
        
        /// <summary>
        /// Task name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Start time of the task
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task end time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// CRON format
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanPlanContent")]
        public string ScanPlanContent{ get; set; }

        /// <summary>
        /// Task type. `0`: Scheduled task, `1`: Scan immediately; `2`: Scanned at the specified time; `3`: Custom.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: u200dThis field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// Task ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Custom list of assets to scan
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SelfDefiningAssets")]
        public string[] SelfDefiningAssets{ get; set; }

        /// <summary>
        /// Estimated period to complete the task
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PredictTime")]
        public long? PredictTime{ get; set; }

        /// <summary>
        /// Estimated completion time of the task
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PredictEndTime")]
        public string PredictEndTime{ get; set; }

        /// <summary>
        /// Number of reports
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReportNumber")]
        public long? ReportNumber{ get; set; }

        /// <summary>
        /// Number of assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetNumber")]
        public long? AssetNumber{ get; set; }

        /// <summary>
        /// Scanning status. `0`: (default) Not scanned; `1`: Scanning; `2`: Scan completed; `3`: Error while scanning; `4`: Scanning stopped
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// Task progress
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// port/poc/weakpass/webcontent/configrisk
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanItem")]
        public string ScanItem{ get; set; }

        /// <summary>
        /// Values: `0` (Scan all); `1` (Scan specific assets); `2` (Scan all expect the specified assets); `3` (Custom assets).
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanAssetType")]
        public long? ScanAssetType{ get; set; }

        /// <summary>
        /// VSS subtask ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VSSTaskId")]
        public string VSSTaskId{ get; set; }

        /// <summary>
        /// CSPM subtask ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CSPMTaskId")]
        public string CSPMTaskId{ get; set; }

        /// <summary>
        /// CWPP vulnerability scan task IDHost missed scan subtask id
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CWPPOCId")]
        public string CWPPOCId{ get; set; }

        /// <summary>
        /// CWPP baseline check task ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CWPBlId")]
        public string CWPBlId{ get; set; }

        /// <summary>
        /// VSS task progess
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VSSTaskProcess")]
        public long? VSSTaskProcess{ get; set; }

        /// <summary>
        /// CSPM task progress
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CSPMTaskProcess")]
        public ulong? CSPMTaskProcess{ get; set; }

        /// <summary>
        /// CWPP vulnerability scan task progress
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CWPPOCProcess")]
        public long? CWPPOCProcess{ get; set; }

        /// <summary>
        /// CWPP baseline check task progress
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CWPBlProcess")]
        public ulong? CWPBlProcess{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// Exception information
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// Day of the month to start the scheduled task
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartDay")]
        public long? StartDay{ get; set; }

        /// <summary>
        /// Scan frequency in days. `1`: Every day; `7`: Every seven days; `30`: Every 30 days; `0`: Scan once only
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// Number of completed tasks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompleteNumber")]
        public long? CompleteNumber{ get; set; }

        /// <summary>
        /// Number of scanned assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompleteAssetNumber")]
        public long? CompleteAssetNumber{ get; set; }

        /// <summary>
        /// Number of risks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// Assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Assets")]
        public TaskAssetObject[] Assets{ get; set; }

        /// <summary>
        /// User `Appid`
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// User name.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Scan task mode: `0` (Standard), `1` (Quick), `2` (Advanced). 
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// Source of scanning request
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanFrom")]
        public string ScanFrom{ get; set; }

        /// <summary>
        /// Whether it's a limited-time free health check. `0`: No; `1`: Yes
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsFree")]
        public long? IsFree{ get; set; }

        /// <summary>
        /// Whether the user is authorized to delete this task. `1` :Yes; `0`: No. It's available for multi-account management.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDelete")]
        public long? IsDelete{ get; set; }

        /// <summary>
        /// Source of the task. `0`: Default, `1`: Assistant; `2`: Health check
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ScanPlanContent", this.ScanPlanContent);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "SelfDefiningAssets.", this.SelfDefiningAssets);
            this.SetParamSimple(map, prefix + "PredictTime", this.PredictTime);
            this.SetParamSimple(map, prefix + "PredictEndTime", this.PredictEndTime);
            this.SetParamSimple(map, prefix + "ReportNumber", this.ReportNumber);
            this.SetParamSimple(map, prefix + "AssetNumber", this.AssetNumber);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "ScanItem", this.ScanItem);
            this.SetParamSimple(map, prefix + "ScanAssetType", this.ScanAssetType);
            this.SetParamSimple(map, prefix + "VSSTaskId", this.VSSTaskId);
            this.SetParamSimple(map, prefix + "CSPMTaskId", this.CSPMTaskId);
            this.SetParamSimple(map, prefix + "CWPPOCId", this.CWPPOCId);
            this.SetParamSimple(map, prefix + "CWPBlId", this.CWPBlId);
            this.SetParamSimple(map, prefix + "VSSTaskProcess", this.VSSTaskProcess);
            this.SetParamSimple(map, prefix + "CSPMTaskProcess", this.CSPMTaskProcess);
            this.SetParamSimple(map, prefix + "CWPPOCProcess", this.CWPPOCProcess);
            this.SetParamSimple(map, prefix + "CWPBlProcess", this.CWPBlProcess);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "StartDay", this.StartDay);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "CompleteNumber", this.CompleteNumber);
            this.SetParamSimple(map, prefix + "CompleteAssetNumber", this.CompleteAssetNumber);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamArrayObj(map, prefix + "Assets.", this.Assets);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "UIN", this.UIN);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "ScanFrom", this.ScanFrom);
            this.SetParamSimple(map, prefix + "IsFree", this.IsFree);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

