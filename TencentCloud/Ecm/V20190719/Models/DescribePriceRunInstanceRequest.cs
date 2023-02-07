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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePriceRunInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance model information
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// System disk information
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// Number of instances
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// Data disk information
        /// </summary>
        [JsonProperty("DataDisk")]
        public DataDisk[] DataDisk{ get; set; }

        /// <summary>
        /// Instance billing type. Valid values:
        /// `0`: Bill by daily resource usage peak (CPU, memory, and disk). It applies only to non-GNR models;
        /// `1`: Bill by usage hours of an instance. It applies only to GNR models. It’s available to beta users now. To enable it, submit a ticket;
        /// `2`: Bill by usage month of an instance. It applies only to GNR models.
        /// If this field is left empty, `0` is selected by default for non-GNR models, and `2` is selected by default for GNR models.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamArrayObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
        }
    }
}

