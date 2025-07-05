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

    public class DescribeLicenseGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of authorizations (including those that are isolated, expired, and in other states)
        /// </summary>
        [JsonProperty("LicenseCnt")]
        public ulong? LicenseCnt{ get; set; }

        /// <summary>
        /// Number of available authorizations
        /// </summary>
        [JsonProperty("AvailableLicenseCnt")]
        public ulong? AvailableLicenseCnt{ get; set; }

        /// <summary>
        /// Number of available Professional Edition authorizations (including those in postpaid mode)
        /// </summary>
        [JsonProperty("AvailableProVersionLicenseCnt")]
        public ulong? AvailableProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// Number of available Ultimate Edition authorizations
        /// </summary>
        [JsonProperty("AvailableFlagshipVersionLicenseCnt")]
        public ulong? AvailableFlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// Number of authorizations about to expire (no more than 15 days left)
        /// </summary>
        [JsonProperty("NearExpiryLicenseCnt")]
        public ulong? NearExpiryLicenseCnt{ get; set; }

        /// <summary>
        /// Number of expired authorizations (excluding deleted ones)
        /// </summary>
        [JsonProperty("ExpireLicenseCnt")]
        public ulong? ExpireLicenseCnt{ get; set; }

        /// <summary>
        /// Automatic upgrade enabling status. True: enabled; false: disabled. Default value: false.
        /// </summary>
        [JsonProperty("AutoOpenStatus")]
        public bool? AutoOpenStatus{ get; set; }

        /// <summary>
        /// PROVERSION_POSTPAY: Pro Edition - postpaid; PROVERSION_PREPAY: Pro edition - prepaid; FLAGSHIP_PREPAY: Ultimate Edition - prepaid.
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// Whether automatic upgrade has been enabled before
        /// </summary>
        [JsonProperty("IsOpenStatusHistory")]
        public bool? IsOpenStatusHistory{ get; set; }

        /// <summary>
        /// Number of used authorizations
        /// </summary>
        [JsonProperty("UsedLicenseCnt")]
        public ulong? UsedLicenseCnt{ get; set; }

        /// <summary>
        /// Number of authorizations that have not expired
        /// </summary>
        [JsonProperty("NotExpiredLicenseCnt")]
        public ulong? NotExpiredLicenseCnt{ get; set; }

        /// <summary>
        /// Total number of Ultimate Edition authorizations (valid orders)
        /// </summary>
        [JsonProperty("FlagshipVersionLicenseCnt")]
        public ulong? FlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// Total number of Pro Edition authorizations (valid orders)
        /// </summary>
        [JsonProperty("ProVersionLicenseCnt")]
        public ulong? ProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// Total number of Inclusive Edition authorizations (those of valid orders)
        /// </summary>
        [JsonProperty("CwpVersionLicenseCnt")]
        public ulong? CwpVersionLicenseCnt{ get; set; }

        /// <summary>
        /// Number of available Inclusive Edition authorizations
        /// </summary>
        [JsonProperty("AvailableLHLicenseCnt")]
        public ulong? AvailableLHLicenseCnt{ get; set; }

        /// <summary>
        /// Auto-purchase switch, true for ON, false for OFF
        /// </summary>
        [JsonProperty("AutoRepurchaseSwitch")]
        public bool? AutoRepurchaseSwitch{ get; set; }

        /// <summary>
        /// Is auto-renewal required for auto-purchase orders, true for ON, false for OFF
        /// </summary>
        [JsonProperty("AutoRepurchaseRenewSwitch")]
        public bool? AutoRepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// Number of terminated orders
        /// </summary>
        [JsonProperty("DestroyOrderNum")]
        public ulong? DestroyOrderNum{ get; set; }

        /// <summary>
        /// Whether automatic renewal is enabled. True: enabled; false: disabled.
        /// </summary>
        [JsonProperty("RepurchaseRenewSwitch")]
        public bool? RepurchaseRenewSwitch{ get; set; }

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
            this.SetParamSimple(map, prefix + "LicenseCnt", this.LicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableLicenseCnt", this.AvailableLicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableProVersionLicenseCnt", this.AvailableProVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableFlagshipVersionLicenseCnt", this.AvailableFlagshipVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "NearExpiryLicenseCnt", this.NearExpiryLicenseCnt);
            this.SetParamSimple(map, prefix + "ExpireLicenseCnt", this.ExpireLicenseCnt);
            this.SetParamSimple(map, prefix + "AutoOpenStatus", this.AutoOpenStatus);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "IsOpenStatusHistory", this.IsOpenStatusHistory);
            this.SetParamSimple(map, prefix + "UsedLicenseCnt", this.UsedLicenseCnt);
            this.SetParamSimple(map, prefix + "NotExpiredLicenseCnt", this.NotExpiredLicenseCnt);
            this.SetParamSimple(map, prefix + "FlagshipVersionLicenseCnt", this.FlagshipVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "ProVersionLicenseCnt", this.ProVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "CwpVersionLicenseCnt", this.CwpVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "AvailableLHLicenseCnt", this.AvailableLHLicenseCnt);
            this.SetParamSimple(map, prefix + "AutoRepurchaseSwitch", this.AutoRepurchaseSwitch);
            this.SetParamSimple(map, prefix + "AutoRepurchaseRenewSwitch", this.AutoRepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "DestroyOrderNum", this.DestroyOrderNum);
            this.SetParamSimple(map, prefix + "RepurchaseRenewSwitch", this.RepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

