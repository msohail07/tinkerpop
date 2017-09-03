#region License

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

#endregion

using System.Collections.Generic;
using Gremlin.Net.Structure;

// THIS IS A GENERATED FILE - DO NOT MODIFY THIS FILE DIRECTLY - see pom.xml
namespace Gremlin.Net.Process.Traversal
{
    /// <summary>
    ///     Graph traversals are the primary way in which graphs are processed.
    /// </summary>
    public class GraphTraversal<S, E> : DefaultTraversal<S, E>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GraphTraversal{SType, EType}" /> class.
        /// </summary>
        public GraphTraversal()
            : this(new List<ITraversalStrategy>(), new Bytecode())
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="GraphTraversal{SType, EType}" /> class.
        /// </summary>
        /// <param name="traversalStrategies">The traversal strategies to be used by this graph traversal at evaluation time.</param>
        /// <param name="bytecode">The <see cref="Bytecode" /> associated with the construction of this graph traversal.</param>
        public GraphTraversal(ICollection<ITraversalStrategy> traversalStrategies, Bytecode bytecode)
        {
            TraversalStrategies = traversalStrategies;
            Bytecode = bytecode;
        }

        private static GraphTraversal<S2, E2> Wrap<S2, E2>(GraphTraversal<S, E> traversal)
        {
            if (typeof(S2) == typeof(S) && typeof(E2) == typeof(E))
            {
                return traversal as GraphTraversal<S2, E2>;
            }
            // New wrapper
            return new GraphTraversal<S2, E2>(traversal.TraversalStrategies, traversal.Bytecode);
        }


        /// <summary>
        ///     Adds the V step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > V (params object[] vertexIdsOrElements)
        {
            var args = new List<object> { vertexIdsOrElements };
            Bytecode.AddStep("V", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the addE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > AddE (Direction direction, string firstVertexKeyOrEdgeLabel, string edgeLabelOrSecondVertexKey, params object[] propertyKeyValues)
        {
            var args = new List<object> { direction, firstVertexKeyOrEdgeLabel, edgeLabelOrSecondVertexKey, propertyKeyValues };
            Bytecode.AddStep("addE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the addE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > AddE (string edgeLabel)
        {
            var args = new List<object> { edgeLabel };
            Bytecode.AddStep("addE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the addInE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > AddInE (string firstVertexKeyOrEdgeLabel, string edgeLabelOrSecondVertexKey, params object[] propertyKeyValues)
        {
            var args = new List<object> { firstVertexKeyOrEdgeLabel, edgeLabelOrSecondVertexKey, propertyKeyValues };
            Bytecode.AddStep("addInE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the addOutE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > AddOutE (string firstVertexKeyOrEdgeLabel, string edgeLabelOrSecondVertexKey, params object[] propertyKeyValues)
        {
            var args = new List<object> { firstVertexKeyOrEdgeLabel, edgeLabelOrSecondVertexKey, propertyKeyValues };
            Bytecode.AddStep("addOutE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the addV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > AddV (string vertexLabel)
        {
            var args = new List<object> { vertexLabel };
            Bytecode.AddStep("addV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the addV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > AddV ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("addV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the addV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > AddV (params object[] propertyKeyValues)
        {
            var args = new List<object> { propertyKeyValues };
            Bytecode.AddStep("addV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the aggregate step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Aggregate (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("aggregate", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the and step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > And (params ITraversal[] andTraversals)
        {
            var args = new List<object> { andTraversals };
            Bytecode.AddStep("and", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the as step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > As (string stepLabel, params string[] stepLabels)
        {
            var args = new List<object> { stepLabel, stepLabels };
            Bytecode.AddStep("as", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the barrier step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Barrier (object barrierConsumer)
        {
            var args = new List<object> { barrierConsumer };
            Bytecode.AddStep("barrier", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the barrier step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Barrier ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("barrier", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the barrier step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Barrier (int maxBarrierSize)
        {
            var args = new List<object> { maxBarrierSize };
            Bytecode.AddStep("barrier", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the both step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > Both (params string[] edgeLabels)
        {
            var args = new List<object> { edgeLabels };
            Bytecode.AddStep("both", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the bothE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > BothE (params string[] edgeLabels)
        {
            var args = new List<object> { edgeLabels };
            Bytecode.AddStep("bothE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the bothV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > BothV ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("bothV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the branch step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Branch<E2> (object function)
        {
            var args = new List<object> { function };
            Bytecode.AddStep("branch", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the branch step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Branch<E2> (ITraversal branchTraversal)
        {
            var args = new List<object> { branchTraversal };
            Bytecode.AddStep("branch", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (Order order)
        {
            var args = new List<object> { order };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (string key, object comparator)
        {
            var args = new List<object> { key, comparator };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (string key)
        {
            var args = new List<object> { key };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (object function)
        {
            var args = new List<object> { function };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (object comparator)
        {
            var args = new List<object> { comparator };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (ITraversal traversal)
        {
            var args = new List<object> { traversal };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (object function, object comparator)
        {
            var args = new List<object> { function, comparator };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (ITraversal traversal, object comparator)
        {
            var args = new List<object> { traversal, comparator };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the by step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > By (T token)
        {
            var args = new List<object> { token };
            Bytecode.AddStep("by", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the cap step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Cap<E2> (string sideEffectKey, params string[] sideEffectKeys)
        {
            var args = new List<object> { sideEffectKey, sideEffectKeys };
            Bytecode.AddStep("cap", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the choose step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Choose<E2> (ITraversal traversalPredicate, ITraversal trueChoice)
        {
            var args = new List<object> { traversalPredicate, trueChoice };
            Bytecode.AddStep("choose", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the choose step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Choose<E2> (ITraversal traversalPredicate, ITraversal trueChoice, ITraversal falseChoice)
        {
            var args = new List<object> { traversalPredicate, trueChoice, falseChoice };
            Bytecode.AddStep("choose", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the choose step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Choose<E2> (ITraversal choiceTraversal)
        {
            var args = new List<object> { choiceTraversal };
            Bytecode.AddStep("choose", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the choose step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Choose<E2> (object choiceFunction)
        {
            var args = new List<object> { choiceFunction };
            Bytecode.AddStep("choose", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the choose step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Choose<E2> (TraversalPredicate choosePredicate, ITraversal trueChoice, ITraversal falseChoice)
        {
            var args = new List<object> { choosePredicate, trueChoice, falseChoice };
            Bytecode.AddStep("choose", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the choose step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Choose<E2> (TraversalPredicate choosePredicate, ITraversal trueChoice)
        {
            var args = new List<object> { choosePredicate, trueChoice };
            Bytecode.AddStep("choose", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the coalesce step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Coalesce<E2> (params ITraversal[] coalesceTraversals)
        {
            var args = new List<object> { coalesceTraversals };
            Bytecode.AddStep("coalesce", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the coin step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Coin (double probability)
        {
            var args = new List<object> { probability };
            Bytecode.AddStep("coin", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the constant step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Constant<E2> (object e)
        {
            var args = new List<object> { e };
            Bytecode.AddStep("constant", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the count step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , long > Count ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("count", args);
            return Wrap< S , long >(this);
        }

        /// <summary>
        ///     Adds the count step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , long > Count (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("count", args);
            return Wrap< S , long >(this);
        }

        /// <summary>
        ///     Adds the cyclicPath step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > CyclicPath ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("cyclicPath", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the dedup step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Dedup (params string[] dedupLabels)
        {
            var args = new List<object> { dedupLabels };
            Bytecode.AddStep("dedup", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the dedup step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Dedup (Scope scope, params string[] dedupLabels)
        {
            var args = new List<object> { scope, dedupLabels };
            Bytecode.AddStep("dedup", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the drop step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Drop ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("drop", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the emit step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Emit (ITraversal emitTraversal)
        {
            var args = new List<object> { emitTraversal };
            Bytecode.AddStep("emit", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the emit step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Emit (TraversalPredicate emitPredicate)
        {
            var args = new List<object> { emitPredicate };
            Bytecode.AddStep("emit", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the emit step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Emit ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("emit", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the filter step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Filter (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("filter", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the filter step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Filter (ITraversal filterTraversal)
        {
            var args = new List<object> { filterTraversal };
            Bytecode.AddStep("filter", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the flatMap step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > FlatMap<E2> (object function)
        {
            var args = new List<object> { function };
            Bytecode.AddStep("flatMap", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the flatMap step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > FlatMap<E2> (ITraversal flatMapTraversal)
        {
            var args = new List<object> { flatMapTraversal };
            Bytecode.AddStep("flatMap", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the fold step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Fold<E2> (object seed, object foldFunction)
        {
            var args = new List<object> { seed, foldFunction };
            Bytecode.AddStep("fold", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the fold step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IList<E> > Fold ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("fold", args);
            return Wrap< S , IList<E> >(this);
        }

        /// <summary>
        ///     Adds the from step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > From (ITraversal fromVertex)
        {
            var args = new List<object> { fromVertex };
            Bytecode.AddStep("from", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the from step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > From (string fromStepLabel)
        {
            var args = new List<object> { fromStepLabel };
            Bytecode.AddStep("from", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the group step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<K, V> > Group<K, V> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("group", args);
            return Wrap< S , IDictionary<K, V> >(this);
        }

        /// <summary>
        ///     Adds the group step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Group (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("group", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the groupCount step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<K, long> > GroupCount<K> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("groupCount", args);
            return Wrap< S , IDictionary<K, long> >(this);
        }

        /// <summary>
        ///     Adds the groupCount step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > GroupCount (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("groupCount", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the groupV3d0 step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<K, V> > GroupV3d0<K, V> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("groupV3d0", args);
            return Wrap< S , IDictionary<K, V> >(this);
        }

        /// <summary>
        ///     Adds the groupV3d0 step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > GroupV3d0 (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("groupV3d0", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (string propertyKey, TraversalPredicate predicate)
        {
            var args = new List<object> { propertyKey, predicate };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (string propertyKey, ITraversal propertyTraversal)
        {
            var args = new List<object> { propertyKey, propertyTraversal };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (string label, string propertyKey, object value)
        {
            var args = new List<object> { label, propertyKey, value };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (string propertyKey)
        {
            var args = new List<object> { propertyKey };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (T accessor, TraversalPredicate predicate)
        {
            var args = new List<object> { accessor, predicate };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (T accessor, ITraversal propertyTraversal)
        {
            var args = new List<object> { accessor, propertyTraversal };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (string propertyKey, object value)
        {
            var args = new List<object> { propertyKey, value };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (T accessor, object value)
        {
            var args = new List<object> { accessor, value };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the has step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Has (string label, string propertyKey, TraversalPredicate predicate)
        {
            var args = new List<object> { label, propertyKey, predicate };
            Bytecode.AddStep("has", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasId step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasId (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("hasId", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasId step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasId (object id, params object[] otherIds)
        {
            var args = new List<object> { id, otherIds };
            Bytecode.AddStep("hasId", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasKey step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasKey (string label, params string[] otherLabels)
        {
            var args = new List<object> { label, otherLabels };
            Bytecode.AddStep("hasKey", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasKey step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasKey (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("hasKey", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasLabel step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasLabel (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("hasLabel", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasLabel step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasLabel (string label, params string[] otherLabels)
        {
            var args = new List<object> { label, otherLabels };
            Bytecode.AddStep("hasLabel", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasNot step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasNot (string propertyKey)
        {
            var args = new List<object> { propertyKey };
            Bytecode.AddStep("hasNot", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasValue step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasValue (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("hasValue", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the hasValue step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > HasValue (object value, params object[] otherValues)
        {
            var args = new List<object> { value, otherValues };
            Bytecode.AddStep("hasValue", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the id step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , object > Id ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("id", args);
            return Wrap< S , object >(this);
        }

        /// <summary>
        ///     Adds the identity step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Identity ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("identity", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the in step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > In (params string[] edgeLabels)
        {
            var args = new List<object> { edgeLabels };
            Bytecode.AddStep("in", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the inE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > InE (params string[] edgeLabels)
        {
            var args = new List<object> { edgeLabels };
            Bytecode.AddStep("inE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the inV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > InV ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("inV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the inject step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Inject (params object[] injections)
        {
            var args = new List<object> { injections };
            Bytecode.AddStep("inject", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the is step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Is (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("is", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the is step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Is (object value)
        {
            var args = new List<object> { value };
            Bytecode.AddStep("is", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the key step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , string > Key ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("key", args);
            return Wrap< S , string >(this);
        }

        /// <summary>
        ///     Adds the label step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , string > Label ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("label", args);
            return Wrap< S , string >(this);
        }

        /// <summary>
        ///     Adds the limit step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Limit (long limit)
        {
            var args = new List<object> { limit };
            Bytecode.AddStep("limit", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the limit step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Limit<E2> (Scope scope, long limit)
        {
            var args = new List<object> { scope, limit };
            Bytecode.AddStep("limit", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the local step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Local<E2> (ITraversal localTraversal)
        {
            var args = new List<object> { localTraversal };
            Bytecode.AddStep("local", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the loops step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , int > Loops ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("loops", args);
            return Wrap< S , int >(this);
        }

        /// <summary>
        ///     Adds the map step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Map<E2> (object function)
        {
            var args = new List<object> { function };
            Bytecode.AddStep("map", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the map step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Map<E2> (ITraversal mapTraversal)
        {
            var args = new List<object> { mapTraversal };
            Bytecode.AddStep("map", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the mapKeys step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > MapKeys<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("mapKeys", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the mapValues step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > MapValues<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("mapValues", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the match step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > Match<E2> (params ITraversal[] matchTraversals)
        {
            var args = new List<object> { matchTraversals };
            Bytecode.AddStep("match", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the max step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Max<E2> (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("max", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the max step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Max<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("max", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the mean step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Mean<E2> (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("mean", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the mean step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Mean<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("mean", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the min step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Min<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("min", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the min step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Min<E2> (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("min", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the not step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Not (ITraversal notTraversal)
        {
            var args = new List<object> { notTraversal };
            Bytecode.AddStep("not", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the option step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Option (ITraversal traversalOption)
        {
            var args = new List<object> { traversalOption };
            Bytecode.AddStep("option", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the option step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Option (object pickToken, ITraversal traversalOption)
        {
            var args = new List<object> { pickToken, traversalOption };
            Bytecode.AddStep("option", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the optional step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Optional<E2> (ITraversal optionalTraversal)
        {
            var args = new List<object> { optionalTraversal };
            Bytecode.AddStep("optional", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the or step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Or (params ITraversal[] orTraversals)
        {
            var args = new List<object> { orTraversals };
            Bytecode.AddStep("or", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the order step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Order ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("order", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the order step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Order (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("order", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the otherV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > OtherV ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("otherV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the out step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > Out (params string[] edgeLabels)
        {
            var args = new List<object> { edgeLabels };
            Bytecode.AddStep("out", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the outE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > OutE (params string[] edgeLabels)
        {
            var args = new List<object> { edgeLabels };
            Bytecode.AddStep("outE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the outV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > OutV ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("outV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the pageRank step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > PageRank ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("pageRank", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the pageRank step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > PageRank (double alpha)
        {
            var args = new List<object> { alpha };
            Bytecode.AddStep("pageRank", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the path step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Path > Path ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("path", args);
            return Wrap< S , Path >(this);
        }

        /// <summary>
        ///     Adds the peerPressure step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > PeerPressure ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("peerPressure", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the profile step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Profile<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("profile", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the profile step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Profile (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("profile", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the program step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Program (object vertexProgram)
        {
            var args = new List<object> { vertexProgram };
            Bytecode.AddStep("program", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the project step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > Project<E2> (string projectKey, params string[] otherProjectKeys)
        {
            var args = new List<object> { projectKey, otherProjectKeys };
            Bytecode.AddStep("project", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the properties step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Properties<E2> (params string[] propertyKeys)
        {
            var args = new List<object> { propertyKeys };
            Bytecode.AddStep("properties", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the property step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Property (object key, object value, params object[] keyValues)
        {
            var args = new List<object> { key, value, keyValues };
            Bytecode.AddStep("property", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the property step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Property (Cardinality cardinality, object key, object value, params object[] keyValues)
        {
            var args = new List<object> { cardinality, key, value, keyValues };
            Bytecode.AddStep("property", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the propertyMap step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > PropertyMap<E2> (params string[] propertyKeys)
        {
            var args = new List<object> { propertyKeys };
            Bytecode.AddStep("propertyMap", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the range step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Range<E2> (Scope scope, long low, long high)
        {
            var args = new List<object> { scope, low, high };
            Bytecode.AddStep("range", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the range step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Range (long low, long high)
        {
            var args = new List<object> { low, high };
            Bytecode.AddStep("range", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the repeat step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Repeat (ITraversal repeatTraversal)
        {
            var args = new List<object> { repeatTraversal };
            Bytecode.AddStep("repeat", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the sack step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Sack<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("sack", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the sack step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Sack (object sackOperator)
        {
            var args = new List<object> { sackOperator };
            Bytecode.AddStep("sack", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the sack step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Sack (object sackOperator, string elementPropertyKey)
        {
            var args = new List<object> { sackOperator, elementPropertyKey };
            Bytecode.AddStep("sack", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the sample step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Sample (int amountToSample)
        {
            var args = new List<object> { amountToSample };
            Bytecode.AddStep("sample", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the sample step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Sample (Scope scope, int amountToSample)
        {
            var args = new List<object> { scope, amountToSample };
            Bytecode.AddStep("sample", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the select step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > Select<E2> (string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            var args = new List<object> { selectKey1, selectKey2, otherSelectKeys };
            Bytecode.AddStep("select", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the select step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > Select<E2> (Pop pop, string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            var args = new List<object> { pop, selectKey1, selectKey2, otherSelectKeys };
            Bytecode.AddStep("select", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the select step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , ICollection<E2> > Select<E2> (Column column)
        {
            var args = new List<object> { column };
            Bytecode.AddStep("select", args);
            return Wrap< S , ICollection<E2> >(this);
        }

        /// <summary>
        ///     Adds the select step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Select<E2> (string selectKey)
        {
            var args = new List<object> { selectKey };
            Bytecode.AddStep("select", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the select step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Select<E2> (Pop pop, string selectKey)
        {
            var args = new List<object> { pop, selectKey };
            Bytecode.AddStep("select", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the sideEffect step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > SideEffect (ITraversal sideEffectTraversal)
        {
            var args = new List<object> { sideEffectTraversal };
            Bytecode.AddStep("sideEffect", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the sideEffect step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > SideEffect (object consumer)
        {
            var args = new List<object> { consumer };
            Bytecode.AddStep("sideEffect", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the simplePath step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > SimplePath ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("simplePath", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the store step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Store (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("store", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the subgraph step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > Subgraph (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("subgraph", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the sum step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Sum<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("sum", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the sum step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Sum<E2> (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("sum", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the tail step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Tail<E2> (Scope scope, long limit)
        {
            var args = new List<object> { scope, limit };
            Bytecode.AddStep("tail", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the tail step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Tail<E2> (Scope scope)
        {
            var args = new List<object> { scope };
            Bytecode.AddStep("tail", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the tail step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Tail (long limit)
        {
            var args = new List<object> { limit };
            Bytecode.AddStep("tail", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the tail step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Tail ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("tail", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the timeLimit step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > TimeLimit (long timeLimit)
        {
            var args = new List<object> { timeLimit };
            Bytecode.AddStep("timeLimit", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the times step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Times (int maxLoops)
        {
            var args = new List<object> { maxLoops };
            Bytecode.AddStep("times", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the to step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > To (Direction direction, params string[] edgeLabels)
        {
            var args = new List<object> { direction, edgeLabels };
            Bytecode.AddStep("to", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the to step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > To (ITraversal toVertex)
        {
            var args = new List<object> { toVertex };
            Bytecode.AddStep("to", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the to step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > To (string toStepLabel)
        {
            var args = new List<object> { toStepLabel };
            Bytecode.AddStep("to", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the toE step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Edge > ToE (Direction direction, params string[] edgeLabels)
        {
            var args = new List<object> { direction, edgeLabels };
            Bytecode.AddStep("toE", args);
            return Wrap< S , Edge >(this);
        }

        /// <summary>
        ///     Adds the toV step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , Vertex > ToV (Direction direction)
        {
            var args = new List<object> { direction };
            Bytecode.AddStep("toV", args);
            return Wrap< S , Vertex >(this);
        }

        /// <summary>
        ///     Adds the tree step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Tree<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("tree", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the tree step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Tree (string sideEffectKey)
        {
            var args = new List<object> { sideEffectKey };
            Bytecode.AddStep("tree", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the unfold step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Unfold<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("unfold", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the union step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Union<E2> (params ITraversal[] unionTraversals)
        {
            var args = new List<object> { unionTraversals };
            Bytecode.AddStep("union", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the until step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Until (ITraversal untilTraversal)
        {
            var args = new List<object> { untilTraversal };
            Bytecode.AddStep("until", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the until step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Until (TraversalPredicate untilPredicate)
        {
            var args = new List<object> { untilPredicate };
            Bytecode.AddStep("until", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the value step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Value<E2> ()
        {
            var args = new List<object> {  };
            Bytecode.AddStep("value", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the valueMap step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > ValueMap<E2> (params string[] propertyKeys)
        {
            var args = new List<object> { propertyKeys };
            Bytecode.AddStep("valueMap", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the valueMap step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , IDictionary<string, E2> > ValueMap<E2> (bool includeTokens, params string[] propertyKeys)
        {
            var args = new List<object> { includeTokens, propertyKeys };
            Bytecode.AddStep("valueMap", args);
            return Wrap< S , IDictionary<string, E2> >(this);
        }

        /// <summary>
        ///     Adds the values step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E2 > Values<E2> (params string[] propertyKeys)
        {
            var args = new List<object> { propertyKeys };
            Bytecode.AddStep("values", args);
            return Wrap< S , E2 >(this);
        }

        /// <summary>
        ///     Adds the where step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Where (TraversalPredicate predicate)
        {
            var args = new List<object> { predicate };
            Bytecode.AddStep("where", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the where step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Where (string startKey, TraversalPredicate predicate)
        {
            var args = new List<object> { startKey, predicate };
            Bytecode.AddStep("where", args);
            return Wrap< S , E >(this);
        }

        /// <summary>
        ///     Adds the where step to this <see cref="GraphTraversal{SType, EType}" />.
        /// </summary>
        public GraphTraversal< S , E > Where (ITraversal whereTraversal)
        {
            var args = new List<object> { whereTraversal };
            Bytecode.AddStep("where", args);
            return Wrap< S , E >(this);
        }

    }
}