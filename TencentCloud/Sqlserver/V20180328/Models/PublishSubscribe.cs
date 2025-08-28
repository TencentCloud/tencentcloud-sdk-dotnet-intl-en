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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublishSubscribe : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublishInstanceId")]
        public string PublishInstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublishInstanceName")]
        public string PublishInstanceName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublishInstanceIp")]
        public string PublishInstanceIp{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubscribeInstanceId")]
        public string SubscribeInstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubscribeInstanceName")]
        public string SubscribeInstanceName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubscribeInstanceIp")]
        public string SubscribeInstanceIp{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DatabaseTupleSet")]
        public DatabaseTupleStatus[] DatabaseTupleSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PublishInstanceId", this.PublishInstanceId);
            this.SetParamSimple(map, prefix + "PublishInstanceName", this.PublishInstanceName);
            this.SetParamSimple(map, prefix + "PublishInstanceIp", this.PublishInstanceIp);
            this.SetParamSimple(map, prefix + "SubscribeInstanceId", this.SubscribeInstanceId);
            this.SetParamSimple(map, prefix + "SubscribeInstanceName", this.SubscribeInstanceName);
            this.SetParamSimple(map, prefix + "SubscribeInstanceIp", this.SubscribeInstanceIp);
            this.SetParamArrayObj(map, prefix + "DatabaseTupleSet.", this.DatabaseTupleSet);
        }
    }
}

