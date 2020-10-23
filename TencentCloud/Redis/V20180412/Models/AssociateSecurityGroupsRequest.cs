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

    public class AssociateSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// Database engine name: mariadb, cdb, cynosdb, dcdb, redis, mongodb, etc.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// ID of the security group to be associated in the format of sg-efil73jd.
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// ID(s) of the instance(s) to be associated in the format of ins-lesecurk. You can specify multiple instances.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
        }
    }
}

