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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancePreRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the ckafka cluster instance Name, an arbitrary string with length no more than 128 characters.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Availability zone. when purchasing a multi-availability zone instance, this parameter specifies the primary az. [view availability zones](https://www.tencentcloud.comom/document/product/597/55246?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// Prepaid purchase duration, such as "1m", exactly one month. value ranges from 1m to 36m.
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// Specifies the standard edition instance specification for the international site. currently only the international site standard edition uses the current field to distinguish specifications, while the domestic site standard edition distinguishes specifications by peak bandwidth. fill in 1 for all instances except the international site standard edition. for international site standard edition instances: [entry-level (general)] fill 1; [standard type (standard)] fill 2; [advanced] fill 3; [capacity type (capacity)] fill 4; [advanced type 1 (specialized-1)] fill 5; [advanced type 2 (specialized-2)] fill 6; [advanced type 3 (specialized-3)] fill 7; [advanced type 4 (specialized-4)] fill 8.
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// VPC Id.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Optional. maximum retention time of instance logs, in minutes. default value: 1440 (1 day). value range: 1 minute to 90 days.
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// Specifies the cluster Id when creating an instance.
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// Auto-Renewal tag for prepaid services. valid values: 0 (default state, not set by the user, initial status), 1 (auto-renew), 2 (explicitly no auto-renew, set by the user).
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Specifies the CKafka version number. valid values: 2.4.1, 2.4.2, 2.8.1, 3.2.3. default value 2.4.1. 2.4.1 and 2.4.2 belong to the same version. any can be passed.
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// Specifies the instance type. valid values: standard (default), profession, premium.
        /// </summary>
        [JsonProperty("SpecificationsType")]
        public string SpecificationsType{ get; set; }

        /// <summary>
        /// Disk size. if it does not match the console specification ratio, the creation cannot succeed. default value is 500. step length is set to 100. can be accessed through the following link: https://www.tencentcloud.comom/document/product/597/122562.?from_cn_redirect=1
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Instance bandwidth. default value: 40 MB/s. minimum value: 20 MB/s. maximum value for advanced edition: 360 MB/s. maximum value for pro edition: 100000 MB/s. standard version fixed bandwidth specifications: 40 MB/s, 100 MB/s, 150 MB/s. view billing specifications through the following link: https://www.tencentcloud.comom/document/product/597/11745.?from_cn_redirect=1
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// Partition size. if it does not match the console specification ratio, creation will fail. default value is 800, step length is 100. billing specifications can be viewed through the following link: https://www.tencentcloud.comom/document/product/597/122563.?from_cn_redirect=1
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Specifies the disk type for a pro/advanced edition instance. you do not need to fill it in for a standard edition instance. valid values: "CLOUD_SSD" for SSD CLOUD disk; "CLOUD_BASIC" for high-performance CLOUD block storage. default value: "CLOUD_BASIC".
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Specifies whether to create a cross-az instance. when the current parameter is true, zoneIds is required.
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// Availability zone list. required item when purchasing a multi-availability zone instance.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Public network bandwidth size, in Mbps. the default is no free 3 Mbps bandwidth. for example, for a total of 3 Mbps public network bandwidth, pass 0 here; for a total of 6 Mbps public network bandwidth, pass 3 here. default value is 0. ensure the input parameter is a multiple of 3.
        /// </summary>
        [JsonProperty("PublicNetworkMonthly")]
        public long? PublicNetworkMonthly{ get; set; }

        /// <summary>
        /// Number of instances to purchase. optional. default value is 1. when you input this parameter, it enables the creation of multiple instances with case-sensitive suffixes added to instanceName.
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// Whether to automatically select a voucher. valid values: 1 (yes), 0 (no). default is 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Elastic bandwidth switch. specifies whether to enable elastic bandwidth. valid values: 0 (not enabled, default), 1 (enabled).
        /// </summary>
        [JsonProperty("ElasticBandwidthSwitch")]
        public long? ElasticBandwidthSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SpecificationsType", this.SpecificationsType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "PublicNetworkMonthly", this.PublicNetworkMonthly);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "ElasticBandwidthSwitch", this.ElasticBandwidthSwitch);
        }
    }
}

