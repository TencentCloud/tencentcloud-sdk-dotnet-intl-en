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

    public class ScanTaskInfoList : AbstractModel
    {
        
        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// start time of the task
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Cron Format
        /// </summary>
        [JsonProperty("ScanPlanContent")]
        public string ScanPlanContent{ get; set; }

        /// <summary>
        /// 0-Periodic Task; 1-Scan Now; 2-Scheduled Scan; 3-Custom.
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Custom Specified Scan Asset Information
        /// </summary>
        [JsonProperty("SelfDefiningAssets")]
        public string[] SelfDefiningAssets{ get; set; }

        /// <summary>
        /// Estimated Time
        /// </summary>
        [JsonProperty("PredictTime")]
        public long? PredictTime{ get; set; }

        /// <summary>
        /// Estimated Completion Time
        /// </summary>
        [JsonProperty("PredictEndTime")]
        public string PredictEndTime{ get; set; }

        /// <summary>
        /// Report Count
        /// </summary>
        [JsonProperty("ReportNumber")]
        public long? ReportNumber{ get; set; }

        /// <summary>
        /// Number of assets
        /// </summary>
        [JsonProperty("AssetNumber")]
        public long? AssetNumber{ get; set; }

        /// <summary>
        /// Scan Status. 0-Initial Value; 1-Scanning; 2-Scan Completed; 3-Scan Error; 4-Scan Stopped.
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// Task progress
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// port/poc/weakpass/webcontent/configrisk
        /// </summary>
        [JsonProperty("ScanItem")]
        public string ScanItem{ get; set; }

        /// <summary>
        /// 0-Full Scan; 1-Specified Asset Scan; 2-Excluded Asset Scan; 3-Custom Specified Asset Scan.
        /// </summary>
        [JsonProperty("ScanAssetType")]
        public long? ScanAssetType{ get; set; }

        /// <summary>
        /// VSS Subtask ID
        /// </summary>
        [JsonProperty("VSSTaskId")]
        public string VSSTaskId{ get; set; }

        /// <summary>
        /// CSPM Subtask ID
        /// </summary>
        [JsonProperty("CSPMTaskId")]
        public string CSPMTaskId{ get; set; }

        /// <summary>
        /// Host Vulnerability Scan Subtask ID
        /// </summary>
        [JsonProperty("CWPPOCId")]
        public string CWPPOCId{ get; set; }

        /// <summary>
        /// Host Baseline Subtask ID
        /// </summary>
        [JsonProperty("CWPBlId")]
        public string CWPBlId{ get; set; }

        /// <summary>
        /// VSS Subtask Progress
        /// </summary>
        [JsonProperty("VSSTaskProcess")]
        public long? VSSTaskProcess{ get; set; }

        /// <summary>
        /// CSPM Subtask Progress
        /// </summary>
        [JsonProperty("CSPMTaskProcess")]
        public ulong? CSPMTaskProcess{ get; set; }

        /// <summary>
        /// Host Vulnerability Scan Subtask Progress
        /// </summary>
        [JsonProperty("CWPPOCProcess")]
        public long? CWPPOCProcess{ get; set; }

        /// <summary>
        /// Host Baseline Subtask Progress
        /// </summary>
        [JsonProperty("CWPBlProcess")]
        public ulong? CWPBlProcess{ get; set; }

        /// <summary>
        /// Exception status code
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// Exception information
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// Number of Days for Periodic Task to Start
        /// </summary>
        [JsonProperty("StartDay")]
        public long? StartDay{ get; set; }

        /// <summary>
        /// Scanning Frequency, in Days. 1-Daily; 7-Weekly; 30-Monthly; 0-Scan Once.
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// Completion Count
        /// </summary>
        [JsonProperty("CompleteNumber")]
        public long? CompleteNumber{ get; set; }

        /// <summary>
        /// Completed Asset Count
        /// </summary>
        [JsonProperty("CompleteAssetNumber")]
        public long? CompleteAssetNumber{ get; set; }

        /// <summary>
        /// risk count
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("Assets")]
        public TaskAssetObject[] Assets{ get; set; }

        /// <summary>
        /// User Appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User Host Account ID
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Checkup Mode. 0-Standard Mode; 1-Quick Mode; 2-Advanced Mode.
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// Scan Source
        /// </summary>
        [JsonProperty("ScanFrom")]
        public string ScanFrom{ get; set; }

        /// <summary>
        /// Whether health checkup is limited or exempted. 0-No; 1-Yes.
        /// </summary>
        [JsonProperty("IsFree")]
        public long? IsFree{ get; set; }

        /// <summary>
        /// Whether it can be deleted. 1-Yes; 0-No. For use with multi-account management.
        /// </summary>
        [JsonProperty("IsDelete")]
        public long? IsDelete{ get; set; }

        /// <summary>
        /// Task Source Type. 0: Default; 1: Assistant; 2: Health Checkup Items.
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

