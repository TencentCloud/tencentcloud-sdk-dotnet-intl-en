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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrometheusInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// COS bucket name
        /// </summary>
        [JsonProperty("COSBucket")]
        public string COSBucket{ get; set; }

        /// <summary>
        /// Data query address
        /// </summary>
        [JsonProperty("QueryAddress")]
        public string QueryAddress{ get; set; }

        /// <summary>
        /// The grafana related information in the instance
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Grafana")]
        public PrometheusGrafanaInfo Grafana{ get; set; }

        /// <summary>
        /// Custom alertmanager
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlertManagerUrl")]
        public string AlertManagerUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "COSBucket", this.COSBucket);
            this.SetParamSimple(map, prefix + "QueryAddress", this.QueryAddress);
            this.SetParamObj(map, prefix + "Grafana.", this.Grafana);
            this.SetParamSimple(map, prefix + "AlertManagerUrl", this.AlertManagerUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

