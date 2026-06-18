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

    public class IaCFile : AbstractModel
    {
        
        /// <summary>
        /// <p>ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>File ID</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>File name.</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>CI/CD name</p>
        /// </summary>
        [JsonProperty("CICDName")]
        public string CICDName{ get; set; }

        /// <summary>
        /// <p>File path</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>File type (1: Dockerfile, 2: Terraform, 3: KubernetesYaml)</p>
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// <p>Total number of risks</p>
        /// </summary>
        [JsonProperty("RiskTotalCnt")]
        public ulong? RiskTotalCnt{ get; set; }

        /// <summary>
        /// <p>Risk level count (0: Low risk, 1: Medium risk, 2: High risk, 3: Critical)</p>
        /// </summary>
        [JsonProperty("RiskLevelCnt")]
        public KeyValueInt[] RiskLevelCnt{ get; set; }

        /// <summary>
        /// <p>Scan time</p>
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// <p>Detection status (0: pending scan, 1: detecting, 2: completed, 3: detection exception)</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Scan failure type (0: No failure, 1: Detection timeout, 2: File format parsing failed, 3: Detection failed)</p>
        /// </summary>
        [JsonProperty("FailType")]
        public long? FailType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "CICDName", this.CICDName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "RiskTotalCnt", this.RiskTotalCnt);
            this.SetParamArrayObj(map, prefix + "RiskLevelCnt.", this.RiskLevelCnt);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailType", this.FailType);
        }
    }
}

