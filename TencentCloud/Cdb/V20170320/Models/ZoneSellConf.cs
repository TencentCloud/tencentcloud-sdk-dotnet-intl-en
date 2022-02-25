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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneSellConf : AbstractModel
    {
        
        /// <summary>
        /// AZ status used to indicate whether instances are purchasable. Value range: `1` (purchasable), `3` (not purchasable), `4` (AZ not displayed)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Whether it is a custom instance type
        /// </summary>
        [JsonProperty("IsCustom")]
        public bool? IsCustom{ get; set; }

        /// <summary>
        /// Whether disaster recovery is supported
        /// </summary>
        [JsonProperty("IsSupportDr")]
        public bool? IsSupportDr{ get; set; }

        /// <summary>
        /// Whether VPC is supported
        /// </summary>
        [JsonProperty("IsSupportVpc")]
        public bool? IsSupportVpc{ get; set; }

        /// <summary>
        /// Maximum purchasable quantity of hourly billed instances
        /// </summary>
        [JsonProperty("HourInstanceSaleMaxNum")]
        public long? HourInstanceSaleMaxNum{ get; set; }

        /// <summary>
        /// Whether it is a default AZ
        /// </summary>
        [JsonProperty("IsDefaultZone")]
        public bool? IsDefaultZone{ get; set; }

        /// <summary>
        /// Whether it is a BM zone
        /// </summary>
        [JsonProperty("IsBm")]
        public bool? IsBm{ get; set; }

        /// <summary>
        /// Supported billing method. Value range: 0 (monthly subscribed), 1 (hourly), 2 (postpaid)
        /// </summary>
        [JsonProperty("PayType")]
        public string[] PayType{ get; set; }

        /// <summary>
        /// Data replication type. Value range: 0 (async), 1 (semi-sync), 2 (strong sync)
        /// </summary>
        [JsonProperty("ProtectMode")]
        public string[] ProtectMode{ get; set; }

        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Array of purchasable instance types
        /// </summary>
        [JsonProperty("SellType")]
        public SellType[] SellType{ get; set; }

        /// <summary>
        /// Multi-AZ information
        /// </summary>
        [JsonProperty("ZoneConf")]
        public ZoneConf ZoneConf{ get; set; }

        /// <summary>
        /// Information of the supported disaster recovery AZ
        /// </summary>
        [JsonProperty("DrZone")]
        public string[] DrZone{ get; set; }

        /// <summary>
        /// Whether cross-AZ read-only access is supported
        /// </summary>
        [JsonProperty("IsSupportRemoteRo")]
        public bool? IsSupportRemoteRo{ get; set; }

        /// <summary>
        /// Information of supported cross-AZ read-only zone
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RemoteRoZone")]
        public string[] RemoteRoZone{ get; set; }

        /// <summary>
        /// AZ status used to indicate whether dedicated instances are purchasable. Valid values: `1 (purchasable), `3` (not purchasable), `4` (AZ not displayed)
        /// </summary>
        [JsonProperty("ExClusterStatus")]
        public long? ExClusterStatus{ get; set; }

        /// <summary>
        /// AZ information of the cross-AZ deployed read-only instances which are associated with a dedicated instance
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExClusterRemoteRoZone")]
        public string[] ExClusterRemoteRoZone{ get; set; }

        /// <summary>
        /// AZ information of a multi-AZ deployed dedicated instance.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExClusterZoneConf")]
        public ZoneConf ExClusterZoneConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
            this.SetParamSimple(map, prefix + "IsSupportDr", this.IsSupportDr);
            this.SetParamSimple(map, prefix + "IsSupportVpc", this.IsSupportVpc);
            this.SetParamSimple(map, prefix + "HourInstanceSaleMaxNum", this.HourInstanceSaleMaxNum);
            this.SetParamSimple(map, prefix + "IsDefaultZone", this.IsDefaultZone);
            this.SetParamSimple(map, prefix + "IsBm", this.IsBm);
            this.SetParamArraySimple(map, prefix + "PayType.", this.PayType);
            this.SetParamArraySimple(map, prefix + "ProtectMode.", this.ProtectMode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "SellType.", this.SellType);
            this.SetParamObj(map, prefix + "ZoneConf.", this.ZoneConf);
            this.SetParamArraySimple(map, prefix + "DrZone.", this.DrZone);
            this.SetParamSimple(map, prefix + "IsSupportRemoteRo", this.IsSupportRemoteRo);
            this.SetParamArraySimple(map, prefix + "RemoteRoZone.", this.RemoteRoZone);
            this.SetParamSimple(map, prefix + "ExClusterStatus", this.ExClusterStatus);
            this.SetParamArraySimple(map, prefix + "ExClusterRemoteRoZone.", this.ExClusterRemoteRoZone);
            this.SetParamObj(map, prefix + "ExClusterZoneConf.", this.ExClusterZoneConf);
        }
    }
}

