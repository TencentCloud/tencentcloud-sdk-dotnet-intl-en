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
        /// <p>Specifies the Name of the ckafka cluster instance, which is any string with a length not more than 128 characters.</p>.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <P>Availability zone. when purchasing a multi-availability zone instance, this parameter specifies the primary az. <a href="https://www.tencentcloud.comom/document/product/597/55246?from_cn_redirect=1">view availability zones</a></p>.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <P>Specifies the prepaid purchase duration, such as "1m" (exactly one month). value ranges from 1m to 36m.</p>.
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// <P>Specifies the standard edition instance specification for the international site. currently only the standard edition on the international site uses the current field to distinguish specifications, while the domestic site standard edition uses peak bandwidth. fill in 1 for all instances except the international site standard edition. for international site standard edition instances: [entry-level (general)] fill 1; [standard type (standard)] fill 2; [advanced] fill 3; [capacity type (capacity)] fill 4; [advanced type 1 (specialized-1)] fill 5; [advanced type 2 (specialized-2)] fill 6; [advanced type 3 (specialized-3)] fill 7; [advanced type 4 (specialized-4)] fill 8.</p>.
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// <p>VPC Id.</p>.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <P>Subnet id.</p>.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <P>Optional. specifies the maximum retention time for instance logs, in minutes. default value: 1440 (1 day) when left blank. configurable range: 1 minute to 90 days.</p>.
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// <p>Specifies the cluster Id when creating an instance. this parameter indicates the cluster Id.</p>.
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// <P>Auto-Renewal tag for prepaid services. 0 means default state (not set by the user, i.e. initial state), 1 means auto-renew, 2 means explicitly no auto-renew (set by the user).</p>.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>Specifies the CKafka version number. valid values: 2.4.1, 2.4.2, 2.8.1, 3.2.3. default value is 2.4.1. 2.4.1 and 2.4.2 belong to the same version, any one can be passed.</p>.
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// <P>Instance type. specifies "standard" for standard edition instance (default), "profession" for professional edition instance, "premium" for advanced edition instance.</p>.
        /// </summary>
        [JsonProperty("SpecificationsType")]
        public string SpecificationsType{ get; set; }

        /// <summary>
        /// <P>Disk size. if it does not match the console specification ratio, creation cannot succeed. default value is 500. step length is set to 100. can be accessed through the following link to view billing specifications: https://www.tencentcloud.comom/document/product/597/122562.?from_cn_redirect=1</p>.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>Instance bandwidth, default value is 40, unit MB/s. minimum value: 20MB/s. advanced edition maximum value: 360MB/s. professional edition maximum value: 100000MB/s. standard version fixed bandwidth specifications: 40MB/s, 100MB/s, 150MB/s. billing specifications can be viewed through the following link: https://www.tencentcloud.comom/document/product/597/11745.?from_cn_redirect=1</p>.
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// <P>Specifies the partition size. if it does not match the console specification ratio, the creation cannot succeed. default value is 800 with a step length of 100. view billing specifications through the following link: https://www.tencentcloud.comom/document/product/597/122563.?from_cn_redirect=1</p>.
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// <p>Tag.</p>.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Specifies the instance disk type for pro edition/advanced edition. standard edition instances do not require this field. valid values: "CLOUD_SSD" (SSD CLOUD disk), "CLOUD_BASIC" (high-performance CLOUD block storage). default value: "CLOUD_BASIC".</p>.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Specifies whether to create a cross-availability zone instance. when the current parameter is true, zoneIds is required.</p>.
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// <P>Availability zone list. required item when purchasing multi-availability zone instance.</p>.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>Specifies the public bandwidth size in Mbps. the free 3 Mbps bandwidth is not included by default. for example, if the total required public network bandwidth is 3 Mbps, input 0 here; if the total required public network bandwidth is 6 Mbps, input 3 here. default value: 0. ensure the input parameter is a multiple of 3.</p>.
        /// </summary>
        [JsonProperty("PublicNetworkMonthly")]
        public long? PublicNetworkMonthly{ get; set; }

        /// <summary>
        /// <p>Specifies the number of instances to purchase. optional. default value is 1. when input this parameter, it will create multiple instances with case-sensitive suffixes added to instanceName.</p>.
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// <P>Specifies whether to automatically select voucher. valid values: 1-yes; 0-no. default is 0.</p>.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <P>Elastic bandwidth switch 0 disable 1 enable (0 default).</p>.
        /// </summary>
        [JsonProperty("ElasticBandwidthSwitch")]
        public long? ElasticBandwidthSwitch{ get; set; }

        /// <summary>
        /// <p>Specifies the custom certificate Id. this parameter is valid only when SpecificationsType is profession. supports custom certificate capacity.</p><p>can be obtained through the <a href="https://www.tencentcloud.comom/document/product/400/41673?from_cn_redirect=1">DescribeCertificateDetail</a> api.</p>.
        /// </summary>
        [JsonProperty("CustomSSLCertId")]
        public string CustomSSLCertId{ get; set; }


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
            this.SetParamSimple(map, prefix + "CustomSSLCertId", this.CustomSSLCertId);
        }
    }
}

