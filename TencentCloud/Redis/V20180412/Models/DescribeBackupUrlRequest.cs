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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Backup ID, which can be obtained through the `RedisBackupSet` parameter returned by the [DescribeInstanceBackups](https://intl.cloud.tencent.com/document/product/239/20011?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// Limit type of the network from which you can download backup files. If this parameter is not configured, the user-defined configuration will be used.
        /// - NoLimit: There is no limit. Backup files can be downloaded from both Tencent Cloud private and public networks.
        /// - LimitOnlyIntranet: Backup files can be downloaded 
        ///  only from the private IP address automatically assigned by Tencent Cloud.
        /// - Customize: Backup files can be downloaded from the user-defined VPC.
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }

        /// <summary>
        /// Only `In` can be passed in for this parameter, indicating that backup files can be downloaded in the custom `LimitVpc`.
        /// </summary>
        [JsonProperty("VpcComparisonSymbol")]
        public string VpcComparisonSymbol{ get; set; }

        /// <summary>
        /// Whether backup files can be downloaded from the custom IP address specified by LimitIp.
        /// - In: yes. This is the default value.
        /// - NotIn: no.
        /// </summary>
        [JsonProperty("IpComparisonSymbol")]
        public string IpComparisonSymbol{ get; set; }

        /// <summary>
        /// VPC ID of the custom backup file download address, which is required if `LimitType` is `Customize`.
        /// </summary>
        [JsonProperty("LimitVpc")]
        public BackupLimitVpcItem[] LimitVpc{ get; set; }

        /// <summary>
        /// VPC IP of the custom backup file download address, which is required if `LimitType` is `Customize`.
        /// </summary>
        [JsonProperty("LimitIp")]
        public string[] LimitIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
            this.SetParamSimple(map, prefix + "VpcComparisonSymbol", this.VpcComparisonSymbol);
            this.SetParamSimple(map, prefix + "IpComparisonSymbol", this.IpComparisonSymbol);
            this.SetParamArrayObj(map, prefix + "LimitVpc.", this.LimitVpc);
            this.SetParamArraySimple(map, prefix + "LimitIp.", this.LimitIp);
        }
    }
}

