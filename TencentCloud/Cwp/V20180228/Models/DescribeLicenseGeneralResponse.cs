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
        /// <p>Total number of licenses (including unavailable licenses such as isolated and expired ones)</p>
        /// </summary>
        [JsonProperty("LicenseCnt")]
        public ulong? LicenseCnt{ get; set; }

        /// <summary>
        /// <p>Available licenses</p>
        /// </summary>
        [JsonProperty("AvailableLicenseCnt")]
        public ulong? AvailableLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of available Pro Edition licenses (including postpaid licenses)</p>
        /// </summary>
        [JsonProperty("AvailableProVersionLicenseCnt")]
        public ulong? AvailableProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of available Ultimate Edition licenses</p>
        /// </summary>
        [JsonProperty("AvailableFlagshipVersionLicenseCnt")]
        public ulong? AvailableFlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of licenses expiring within 15 days</p>
        /// </summary>
        [JsonProperty("NearExpiryLicenseCnt")]
        public ulong? NearExpiryLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of expired licenses (excluding deleted records)</p>
        /// </summary>
        [JsonProperty("ExpireLicenseCnt")]
        public ulong? ExpireLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Automatic upgrade switch status. Default value: false. true: enabled; false: disabled.</p>
        /// </summary>
        [JsonProperty("AutoOpenStatus")]
        public bool? AutoOpenStatus{ get; set; }

        /// <summary>
        /// <p>PROVERSION_POSTPAY: Pro Edition - postpaid; PROVERSION_PREPAY: Pro Edition - prepaid; FLAGSHIP_PREPAY: Ultimate Edition - prepaid.</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>Whether automatic upgrade has been enabled before</p>
        /// </summary>
        [JsonProperty("IsOpenStatusHistory")]
        public bool? IsOpenStatusHistory{ get; set; }

        /// <summary>
        /// <p>Number of used licenses</p>
        /// </summary>
        [JsonProperty("UsedLicenseCnt")]
        public ulong? UsedLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of unexpired licenses</p>
        /// </summary>
        [JsonProperty("NotExpiredLicenseCnt")]
        public ulong? NotExpiredLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Total number of Ultimate Edition licenses (valid orders)</p>
        /// </summary>
        [JsonProperty("FlagshipVersionLicenseCnt")]
        public ulong? FlagshipVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Total number of Pro Edition licenses (valid orders)</p>
        /// </summary>
        [JsonProperty("ProVersionLicenseCnt")]
        public ulong? ProVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Lightweight edition total number of licenses (valid order licenses count)</p>
        /// </summary>
        [JsonProperty("CwpVersionLicenseCnt")]
        public ulong? CwpVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of available Lightweight Edition licenses</p>
        /// </summary>
        [JsonProperty("AvailableLHLicenseCnt")]
        public ulong? AvailableLHLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Auto-purchase switch. true: enabled; false: disabled.</p>
        /// </summary>
        [JsonProperty("AutoRepurchaseSwitch")]
        public bool? AutoRepurchaseSwitch{ get; set; }

        /// <summary>
        /// <p>Whether auto-purchase orders are automatically renewed. true: enabled; false: disabled.</p>
        /// </summary>
        [JsonProperty("AutoRepurchaseRenewSwitch")]
        public bool? AutoRepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// <p>Number of terminated orders</p>
        /// </summary>
        [JsonProperty("DestroyOrderNum")]
        public ulong? DestroyOrderNum{ get; set; }

        /// <summary>
        /// <p>Auto-renewal switch for auto-purchase. true: enabled; false: disabled.</p>
        /// </summary>
        [JsonProperty("RepurchaseRenewSwitch")]
        public bool? RepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to automatically bind RASP protection to newly added machines. false: disabled; true: enabled.</p>
        /// </summary>
        [JsonProperty("AutoBindRaspSwitch")]
        public bool? AutoBindRaspSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to automatically enable RASP protection for newly added machines. false: disabled; true: enabled.</p>
        /// </summary>
        [JsonProperty("AutoOpenRaspSwitch")]
        public bool? AutoOpenRaspSwitch{ get; set; }

        /// <summary>
        /// <p>Whether the auto-downgrade switch is enabled</p>
        /// </summary>
        [JsonProperty("AutoDowngradeSwitch")]
        public bool? AutoDowngradeSwitch{ get; set; }

        /// <summary>
        /// <p>Number of available AI Protection Edition licenses</p>
        /// </summary>
        [JsonProperty("AvailableAISecurityLicenseCnt")]
        public ulong? AvailableAISecurityLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Total number of AI Protection Edition licenses</p>
        /// </summary>
        [JsonProperty("AISecurityVersionLicenseCnt")]
        public ulong? AISecurityVersionLicenseCnt{ get; set; }

        /// <summary>
        /// <p>Number of available licenses after combining application protection licenses with Ultimate Edition licenses</p>
        /// </summary>
        [JsonProperty("ApplicationAvailableLicenseCnt")]
        public ulong? ApplicationAvailableLicenseCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "AutoBindRaspSwitch", this.AutoBindRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoOpenRaspSwitch", this.AutoOpenRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoDowngradeSwitch", this.AutoDowngradeSwitch);
            this.SetParamSimple(map, prefix + "AvailableAISecurityLicenseCnt", this.AvailableAISecurityLicenseCnt);
            this.SetParamSimple(map, prefix + "AISecurityVersionLicenseCnt", this.AISecurityVersionLicenseCnt);
            this.SetParamSimple(map, prefix + "ApplicationAvailableLicenseCnt", this.ApplicationAvailableLicenseCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

