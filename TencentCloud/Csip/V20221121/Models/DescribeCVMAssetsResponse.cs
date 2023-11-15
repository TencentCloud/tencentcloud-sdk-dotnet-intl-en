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

    public class DescribeCVMAssetsResponse : AbstractModel
    {
        
        /// <summary>
        /// u200c-
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// u200c-
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Data")]
        public CVMAssetVO[] Data{ get; set; }

        /// <summary>
        /// List of regions
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionList")]
        public FilterDataObject[] RegionList{ get; set; }

        /// <summary>
        /// Protection status
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenseStatusList")]
        public FilterDataObject[] DefenseStatusList{ get; set; }

        /// <summary>
        /// List of VPCs
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcList")]
        public FilterDataObject[] VpcList{ get; set; }

        /// <summary>
        /// List of asset types
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetTypeList")]
        public FilterDataObject[] AssetTypeList{ get; set; }

        /// <summary>
        /// List of operating systems
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SystemTypeList")]
        public FilterDataObject[] SystemTypeList{ get; set; }

        /// <summary>
        /// List of IP types
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpTypeList")]
        public FilterDataObject[] IpTypeList{ get; set; }

        /// <summary>
        /// List of AppIds
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppIdList")]
        public FilterDataObject[] AppIdList{ get; set; }

        /// <summary>
        /// List of availability zones
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneList")]
        public FilterDataObject[] ZoneList{ get; set; }

        /// <summary>
        /// List of operating systems
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OsList")]
        public FilterDataObject[] OsList{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArrayObj(map, prefix + "DefenseStatusList.", this.DefenseStatusList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamArrayObj(map, prefix + "AssetTypeList.", this.AssetTypeList);
            this.SetParamArrayObj(map, prefix + "SystemTypeList.", this.SystemTypeList);
            this.SetParamArrayObj(map, prefix + "IpTypeList.", this.IpTypeList);
            this.SetParamArrayObj(map, prefix + "AppIdList.", this.AppIdList);
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamArrayObj(map, prefix + "OsList.", this.OsList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

