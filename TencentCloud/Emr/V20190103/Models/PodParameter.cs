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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodParameter : AbstractModel
    {
        
        /// <summary>
        /// ID of TKE or EKS cluster
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Custom permissions
        /// Example:
        /// {
        ///   "apiVersion": "v1",
        ///   "Clusters": [
        ///     {
        ///       "cluster": {
        ///         "certificate-authority-data": "xxxxxx==",
        ///         "server": "https://xxxxx.com"
        ///       },
        ///       "name": "cls-xxxxx"
        ///     }
        ///   ],
        ///   "contexts": [
        ///     {
        ///       "context": {
        ///         "cluster": "cls-xxxxx",
        ///         "user": "100014xxxxx"
        ///       },
        ///       "name": "cls-a44yhcxxxxxxxxxx"
        ///     }
        ///   ],
        ///   "current-context": "cls-a4xxxx-context-default",
        ///   "kind": "Config",
        ///   "preferences": {},
        ///   "users": [
        ///     {
        ///       "name": "100014xxxxx",
        ///       "user": {
        ///         "client-certificate-data": "xxxxxx",
        ///         "client-key-data": "xxxxxx"
        ///       }
        ///     }
        ///   ]
        /// }
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// Custom parameters
        /// Example:
        /// {
        ///     "apiVersion": "apps/v1",
        ///     "kind": "Deployment",
        ///     "metadata": {
        ///       "name": "test-deployment",
        ///       "labels": {
        ///         "app": "test"
        ///       }
        ///     },
        ///     "spec": {
        ///       "replicas": 3,
        ///       "selector": {
        ///         "matchLabels": {
        ///           "app": "test-app"
        ///         }
        ///       },
        ///       "template": {
        ///         "metadata": {
        ///           "annotations": {
        ///             "your-organization.com/department-v1": "test-example-v1",
        ///             "your-organization.com/department-v2": "test-example-v2"
        ///           },
        ///           "labels": {
        ///             "app": "test-app",
        ///             "environment": "production"
        ///           }
        ///         },
        ///         "spec": {
        ///           "nodeSelector": {
        ///             "your-organization/node-test": "test-node"
        ///           },
        ///           "containers": [
        ///             {
        ///               "name": "nginx",
        ///               "image": "nginx:1.14.2",
        ///               "ports": [
        ///                 {
        ///                   "containerPort": 80
        ///                 }
        ///               ]
        ///             }
        ///           ],
        ///           "affinity": {
        ///             "nodeAffinity": {
        ///               "requiredDuringSchedulingIgnoredDuringExecution": {
        ///                 "nodeSelectorTerms": [
        ///                   {
        ///                     "matchExpressions": [
        ///                       {
        ///                         "key": "disk-type",
        ///                         "operator": "In",
        ///                         "values": [
        ///                           "ssd",
        ///                           "sas"
        ///                         ]
        ///                       },
        ///                       {
        ///                         "key": "cpu-num",
        ///                         "operator": "Gt",
        ///                         "values": [
        ///                           "6"
        ///                         ]
        ///                       }
        ///                     ]
        ///                   }
        ///                 ]
        ///               }
        ///             }
        ///           }
        ///         }
        ///       }
        ///     }
        ///   }
        /// </summary>
        [JsonProperty("Parameter")]
        public string Parameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Parameter", this.Parameter);
        }
    }
}

