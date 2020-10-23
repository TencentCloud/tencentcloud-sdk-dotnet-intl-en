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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteAclRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID information
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ACL resource type. 0: UNKNOWN, 1: ANY, 2: TOPIC, 3: GROUP, 4: CLUSTER, 5: TRANSACTIONAL_ID. Currently, only `TOPIC` is available, and other fields will be used for future ACLs compatible with open-source Kafka
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// Resource name, which is related to `resourceType`. For example, if `resourceType` is `TOPIC`, this field indicates the topic name; if `resourceType` is `GROUP`, this field indicates the group name
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// ACL operation mode. 0: UNKNOWN, 1: ANY, 2: ALL, 3: READ, 4: WRITE, 5: CREATE, 6: DELETE, 7: ALTER, 8: DESCRIBE, 9: CLUSTER_ACTION, 10: DESCRIBE_CONFIGS, 11: ALTER_CONFIGS, 12: IDEMPOTEN_WRITE. Currently, CKafka only supports `READ` and `WRITE`, and other values will be used for future ACLs compatible with open-source Kafka
        /// </summary>
        [JsonProperty("Operation")]
        public long? Operation{ get; set; }

        /// <summary>
        /// Permission type. 0: UNKNOWN, 1: ANY, 2: DENY, 3: ALLOW. Currently, CKafka supports `ALLOW` (equivalent to allowlist), and other fields will be used for future ACLs compatible with open-source Kafka
        /// </summary>
        [JsonProperty("PermissionType")]
        public long? PermissionType{ get; set; }

        /// <summary>
        /// The default value is `*`, which means that any host can access. Currently, CKafka does not support the host as `*`, but the future product based on the open-source Kafka will directly support this
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// User list. The default value is `*`, which means that any user can access. The current user can only be one included in the user list
        /// </summary>
        [JsonProperty("Principal")]
        public string Principal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "PermissionType", this.PermissionType);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Principal", this.Principal);
        }
    }
}

