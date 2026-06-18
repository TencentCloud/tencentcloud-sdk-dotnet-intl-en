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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachineGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Total number of assets</p>
        /// </summary>
        [JsonProperty("MachineCnt")]
        public ulong? MachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of Tencent Cloud machines</p>
        /// </summary>
        [JsonProperty("TencentCloudMachineCnt")]
        [System.Obsolete]
        public ulong? TencentCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of Alibaba Cloud machines</p>
        /// </summary>
        [JsonProperty("AliCloudMachineCnt")]
        [System.Obsolete]
        public ulong? AliCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of Baidu Cloud machines</p>
        /// </summary>
        [JsonProperty("BaiduCloudMachineCnt")]
        [System.Obsolete]
        public ulong? BaiduCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of IDC machines</p>
        /// </summary>
        [JsonProperty("IDCMachineCnt")]
        [System.Obsolete]
        public ulong? IDCMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of machines from other cloud service vendors</p>
        /// </summary>
        [JsonProperty("OtherCloudMachineCnt")]
        [System.Obsolete]
        public ulong? OtherCloudMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of protected machines</p>
        /// </summary>
        [JsonProperty("ProtectMachineCnt")]
        public ulong? ProtectMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of protected Basic Edition machines</p>
        /// </summary>
        [JsonProperty("BaseMachineCnt")]
        public ulong? BaseMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of protected Pro Edition machines</p>
        /// </summary>
        [JsonProperty("SpecialtyMachineCnt")]
        public ulong? SpecialtyMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of protected Ultimate Edition machines</p>
        /// </summary>
        [JsonProperty("FlagshipMachineCnt")]
        public ulong? FlagshipMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of risky machines</p>
        /// </summary>
        [JsonProperty("RiskMachineCnt")]
        public ulong? RiskMachineCnt{ get; set; }

        /// <summary>
        /// <p>Change in the number of risky machines compared with yesterday</p>
        /// </summary>
        [JsonProperty("CompareYesterdayRiskMachineCnt")]
        public long? CompareYesterdayRiskMachineCnt{ get; set; }

        /// <summary>
        /// <p>Change in the number of unprotected machines compared with yesterday</p>
        /// </summary>
        [JsonProperty("CompareYesterdayNotProtectMachineCnt")]
        public long? CompareYesterdayNotProtectMachineCnt{ get; set; }

        /// <summary>
        /// <p>Change in the number of machines expiring soon compared with yesterday</p>
        /// </summary>
        [JsonProperty("CompareYesterdayDeadlineMachineCnt")]
        public long? CompareYesterdayDeadlineMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of machines about to expire</p>
        /// </summary>
        [JsonProperty("DeadlineMachineCnt")]
        public ulong? DeadlineMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of unprotected machines</p>
        /// </summary>
        [JsonProperty("NotProtectMachineCnt")]
        public ulong? NotProtectMachineCnt{ get; set; }

        /// <summary>
        /// <p>Number of protected Lighthouse machines</p>
        /// </summary>
        [JsonProperty("LHGeneralDiscountCnt")]
        public ulong? LHGeneralDiscountCnt{ get; set; }

        /// <summary>
        /// <p>Change in the number of newly added hosts compared with yesterday</p>
        /// </summary>
        [JsonProperty("CompareYesterdayMachineCnt")]
        public long? CompareYesterdayMachineCnt{ get; set; }

        /// <summary>
        /// <p>Automatic cleanup time, maximum 720 hours, minimum 0, default 0, 0=disabled</p>
        /// </summary>
        [JsonProperty("MachineDestroyAfterOfflineHours")]
        public ulong? MachineDestroyAfterOfflineHours{ get; set; }

        /// <summary>
        /// <p>Cloud server type array</p>
        /// </summary>
        [JsonProperty("CloudFrom")]
        public CloudFromCnt[] CloudFrom{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineCnt", this.MachineCnt);
            this.SetParamSimple(map, prefix + "TencentCloudMachineCnt", this.TencentCloudMachineCnt);
            this.SetParamSimple(map, prefix + "AliCloudMachineCnt", this.AliCloudMachineCnt);
            this.SetParamSimple(map, prefix + "BaiduCloudMachineCnt", this.BaiduCloudMachineCnt);
            this.SetParamSimple(map, prefix + "IDCMachineCnt", this.IDCMachineCnt);
            this.SetParamSimple(map, prefix + "OtherCloudMachineCnt", this.OtherCloudMachineCnt);
            this.SetParamSimple(map, prefix + "ProtectMachineCnt", this.ProtectMachineCnt);
            this.SetParamSimple(map, prefix + "BaseMachineCnt", this.BaseMachineCnt);
            this.SetParamSimple(map, prefix + "SpecialtyMachineCnt", this.SpecialtyMachineCnt);
            this.SetParamSimple(map, prefix + "FlagshipMachineCnt", this.FlagshipMachineCnt);
            this.SetParamSimple(map, prefix + "RiskMachineCnt", this.RiskMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayRiskMachineCnt", this.CompareYesterdayRiskMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayNotProtectMachineCnt", this.CompareYesterdayNotProtectMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayDeadlineMachineCnt", this.CompareYesterdayDeadlineMachineCnt);
            this.SetParamSimple(map, prefix + "DeadlineMachineCnt", this.DeadlineMachineCnt);
            this.SetParamSimple(map, prefix + "NotProtectMachineCnt", this.NotProtectMachineCnt);
            this.SetParamSimple(map, prefix + "LHGeneralDiscountCnt", this.LHGeneralDiscountCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayMachineCnt", this.CompareYesterdayMachineCnt);
            this.SetParamSimple(map, prefix + "MachineDestroyAfterOfflineHours", this.MachineDestroyAfterOfflineHours);
            this.SetParamArrayObj(map, prefix + "CloudFrom.", this.CloudFrom);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

